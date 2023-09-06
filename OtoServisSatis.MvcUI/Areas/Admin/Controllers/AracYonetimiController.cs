using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtoServisSatis.MvcUI.Areas.Admin.Controllers
{
    public class AracYonetimiController : Controller
    {
        AracManager manager = new AracManager();
        MarkaManager markamanager = new MarkaManager();
        // GET: Admin/AracYonetimi
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }
    }
}