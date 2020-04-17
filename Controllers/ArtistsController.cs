using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment5.ViewModels;

namespace Assignment5.Controllers
{
    [Authorize]
    public class ArtistsController : Controller
    {
        private Manager m = new Manager();

        // GET: Artist
        public ActionResult Index()
        {
            return View(m.ArtistGetAll());
        }

        // GET: Artist/Details/5
        public ActionResult Details(int? id)
        {
            ArtistWithMediaViewModel artist = m.ArtistGetByIDWithMedia(id ?? 0);
            if (artist == null)
                return HttpNotFound();
            else
                return View(artist);
        }

        // GET: Artist/Create
        [Authorize(Roles = "Executive")]
        public ActionResult Create()
        {
            ArtistAddFormViewModel artist = new ArtistAddFormViewModel();
            artist.GenreList = new SelectList(m.GenreGetAll(), "Id", "Name");
            return View(artist);
        }

        // POST: Artist/Create
        [HttpPost]
        [ValidateInput(false)]
        [Authorize(Roles = "Executive")]
        public ActionResult Create(ArtistAddViewModel newArtist)
        {
            if (!ModelState.IsValid)
                return View(newArtist);
            try
            {
                var addedArtist = m.ArtistAdd(newArtist);
                if (addedArtist == null)
                    return View(newArtist);
                else
                    return RedirectToAction("Details", new { id = addedArtist.Id });
            }
            catch
            {
                return View(newArtist);
            }
        }

        [Authorize(Roles = "Coordinator")]
        [Route("Artists/{id}/AddAlbum")]
        public ActionResult AddAlbum(int? id)
        {
            ArtistWithDetailViewModel artist = m.ArtistGetByID(id ?? 0);
            if (artist == null)
                return HttpNotFound();

            AlbumAddFormViewModel album = new AlbumAddFormViewModel();
            album.ArtistName = artist.Name;
            album.GenreList = new SelectList(m.GenreGetAll(), "Id", "Name");
            album.ArtistId = artist.Id;

            return View(album);
        }

        [HttpPost]
        [ValidateInput(false)]
        [Authorize(Roles = "Coordinator")]
        [Route("Artists/{id}/AddAlbum")]
        public ActionResult AddAlbum(AlbumAddViewModel newAlbum)
        {
            if (!ModelState.IsValid)
                return View(newAlbum);
            try
            {
                var addedAlbum = m.AlbumAdd(newAlbum);
                if (addedAlbum == null)
                    return View(newAlbum);
                else
                    return RedirectToAction("Details", "Albums", new { id = addedAlbum.Id });
            }
            catch
            {
                return View(newAlbum);
            }
        }

        [Authorize(Roles = "Executive")]
        [Route("Artists/{id}/AddMedia")]
        public ActionResult AddMedia(int? id)
        {
            ArtistWithDetailViewModel artist = m.ArtistGetByID(id ?? 0);

            if (artist == null)
                return HttpNotFound();

            MediaItemAddFormViewModel form = new MediaItemAddFormViewModel();
            form.ArtistId = artist.Id;
            form.ArtistInfo = $"{artist.Name}, Main Genre: {artist.Genre}";

            return View(form);
        }

        [HttpPost]
        [Authorize(Roles = "Executive")]
        [Route("Artists/{id}/AddMedia")]
        public ActionResult AddMedia(int? id, MediaItemAddViewModel newMedia)
        {
            if (!ModelState.IsValid && id.GetValueOrDefault() == newMedia.ArtistId)
                return View(newMedia);

            ArtistBaseViewModel addedMedia = m.ArtistMediaAdd(newMedia);

            if (addedMedia == null)
                return View(newMedia);

            return RedirectToAction("Details", new { id = addedMedia.Id });
        }
    }
}
