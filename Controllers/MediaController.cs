using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Win32;

namespace Assignment5.Controllers
{
    [Authorize]
    public class MediaController : Controller
    {
        Manager m = new Manager();

        // GET: Media
        public ActionResult Index()
        {
            return View("index", "home");
        }

        // GET: Media/5
        [Route("media/{stringId}")]
        public ActionResult Details(string stringId = "")
        {
            var media = m.ArtistMediaGetByID(stringId);

            if (media == null)
            {
                return HttpNotFound();
            }
            else
            {
                return File(media.Content, media.ContentType);
            }
        }

        // GET: Media/5
        [Route("media/{stringId}/download")]
        public ActionResult DetailsDownload(string stringId = "")
        {
            var media = m.ArtistMediaGetByID(stringId);

            if (media == null)
            {
                return HttpNotFound();
            }
            else
            {
                // Get file extension, assumes the web server is Microsoft IIS based
                // Must get the extension from the Registry (which is a key-value storage structure for configuration settings, for the Windows operating system and apps that opt to use the Registry)

                // Working variables
                string extension;
                RegistryKey key;
                object value;

                // Open the Registry, attempt to locate the key
                key = Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + media.ContentType, false);
                // Attempt to read the value of the key
                value = (key == null) ? null : key.GetValue("Extension", null);
                // Build/create the file extension string
                extension = (value == null) ? string.Empty : value.ToString();

                // Create a new Content-Disposition header
                var cd = new System.Net.Mime.ContentDisposition
                {
                    // Assemble the file name + extension
                    FileName = $"img-{stringId}{extension}",
                    // Force the media item to be saved (not viewed)
                    Inline = false
                };
                // Add the header to the response
                Response.AppendHeader("Content-Disposition", cd.ToString());

                return File(media.Content, media.ContentType);
            }
        }
    }
}
