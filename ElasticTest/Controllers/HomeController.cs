using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ElasticTest.Controllers
{
    public class HomeController : Controller
    {
        private UploadHandler _uploadHandler;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //
        // POST: /Home/UploadFile
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UploadFile()
        {
            var httpPostedFile = HttpContext.Request.Files["UploadFile"];
            Boolean result = await UploadHandler.saveFile(httpPostedFile);
            if(!result)
            {
                return RedirectToAction("Index", new { Message = "Could not upload" });
            }
            return RedirectToAction("Index", new { Message = "Upload successful" });
        }

        private class UploadHandler
        {
            internal static Task<bool> saveFile(HttpPostedFileBase httpPostedFile)
            {
                throw new NotImplementedException();
            }
        }
    }
}