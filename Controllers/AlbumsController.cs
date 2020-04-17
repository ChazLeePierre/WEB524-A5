using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment5.ViewModels;

namespace Assignment5.Controllers
{
    [Authorize]
    public class AlbumsController : Controller
    {
        private Manager m = new Manager();

        // GET: Album
        public ActionResult Index()
        {
            return View(m.AlbumGetAll());
        }

        // GET: Album/Details/5
        public ActionResult Details(int? id)
        {
            AlbumWithDetailViewModel album = m.AlbumGetByID(id ?? 0);
            if (album == null)
                return HttpNotFound();
            else
                return View(album);
        }

        // GET: Album/{id}/AddTrack
        [Authorize(Roles = "Clerk")]
        [Route("Albums/{id}/AddTrack")]
        public ActionResult AddTrack(int? id)
        {
            AlbumWithDetailViewModel album = m.AlbumGetByID(id ?? 0);

            if (album == null)
                return HttpNotFound();

            TrackAddFormViewModel track = new TrackAddFormViewModel();
            track.AlbumName = album.Name;
            track.AlbumId = album.Id;
            track.GenreList = new SelectList(m.GenreGetAll(), "Id", "Name");

            return View(track);
        }

        // POST: Album/{id}/AddTrack
        [HttpPost]
        [Authorize(Roles = "Clerk")]
        [Route("Albums/{id}/AddTrack")]
        public ActionResult AddTrack(TrackAddViewModel newTrack)
        {
            if (!ModelState.IsValid)
                return View(newTrack);
            try
            {
                var addedTrack = m.TrackAdd(newTrack);
                if (addedTrack == null)
                    return View(newTrack);
                else
                    return RedirectToAction("Details", "Tracks", new { id = addedTrack.Id });
            }
            catch
            {
                return View(newTrack);
            }
        }
    }
}
