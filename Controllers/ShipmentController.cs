using Kovan.Core.DataManager;
using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kovan.Controllers
{
    public class ShipmentController : Controller
    {
        public ActionResult Index()
        {
            using (SharedManager dm = new SharedManager())
            {
                ViewData["selectDepots"] = dm.GetSelectDepots();
                ViewData["selectMaterials"] = dm.GetSelectMaterials();
            }
            return View();
        }
        [HttpPost]
        public ActionResult SaveShipment(List<ShipmentModel> shipments)
        {
            return RedirectToAction("Index");
        }
    }
}