using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Controllers
{
    [Authorize]
    public class AudioController : Controller
    {
        Manager m = new Manager();

        // GET: Audio
        public ActionResult Index()
        {
            return View("index", "home");
        }

        // GET: Audio/5
        [Route("audio/{id}")]
        public ActionResult Details(int? id)
        {
            var track = m.TrackAudioGetById(id.GetValueOrDefault());

            if (track == null)
            {
                return HttpNotFound();
            }
            else
            {
                return File(track.Audio, track.AudioContentType);
            }
        }
    }
}
