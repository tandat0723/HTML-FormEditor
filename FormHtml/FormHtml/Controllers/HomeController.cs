using FormHtml.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FormHtml.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public JsonResult Insert(string TEXT)
        {
            ResponseData response = new ResponseData();
            response.Insert(TEXT);

            return Json(JsonRequestBehavior.AllowGet);
        }

    }
}