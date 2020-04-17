using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment5.ViewModels;

namespace Assignment5.Controllers
{
    [Authorize]
    public class TracksController : Controller
    {
        private Manager m = new Manager();

        // GET: Track
        public ActionResult Index()
        {
            return View(m.TrackGetAll());
        }

        // GET: Track/Details/5
        public ActionResult Details(int? id)
        {
            TrackWithDetailViewModel track = m.TrackGetByID(id ?? 0);
            if (track == null)
                return HttpNotFound();
            else
                return View(track);
        }

        // GET: Track/Edit/5
        [Authorize(Roles = "Clerk")]
        public ActionResult Edit(int? id)
        {
            TrackWithDetailViewModel track = m.TrackGetByID(id ?? 0);

            if (track == null)
                return HttpNotFound();

            TrackEditFormViewModel form = m.mapper.Map<TrackEditFormViewModel>(track);

            return View(form);
        }

        [HttpPost]
        [Authorize(Roles = "Clerk")]
        public ActionResult Edit(int? id, TrackEditViewModel track)
        {
            try
            {
                if (!ModelState.IsValid)
                    return RedirectToAction("Edit", new { id = track.Id });

                if ((id ?? 0) != track.Id)
                    return RedirectToAction("Index");

                TrackWithDetailViewModel trackEdit = m.TrackEdit(track);

                if (trackEdit == null)
                    return RedirectToAction("Edit", new { id = track.Id });

                return RedirectToAction("Details", new { id = track.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Track/Delete/5
        [Authorize(Roles = "Clerk")]
        public ActionResult Delete(int? id)
        {
            TrackWithDetailViewModel track = m.TrackGetByID(id ?? 0);

            if (track == null)
                return HttpNotFound();

            TrackDeleteFormViewModel form = m.mapper.Map<TrackDeleteFormViewModel>(track);

            return View(form);
        }

        [HttpPost]
        [Authorize(Roles = "Clerk")]
        public ActionResult Delete(int? id, TrackDeleteViewModel track)
        {
            try
            {
                if ((id ?? 0) != track.Id)
                    return RedirectToAction("Details", new { id = track.Id });

                if (m.TrackDelete(track))
                    return RedirectToAction("Index");

                return RedirectToAction("Details", new { id = track.Id });
            }
            catch
            {
                return View();
            }
        }

    }
}
