using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_FAQ_BYUIS.Controllers
{
    public class DegreesController : Controller
    {
        // GET: Degrees
        public ActionResult Catalog()
        {
            //Creat dropdown list
            List<SelectListItem> degrees = new List<SelectListItem>();
            degrees.Add(new SelectListItem { Text = "BSIS", Value = "0", Selected = true });
            degrees.Add(new SelectListItem { Text = "MISM", Value = "1", Selected = false });
            ViewBag.DegreeNames = degrees;

            return View();
        }
    }
}