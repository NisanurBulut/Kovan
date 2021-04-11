using Kovan.Core.DataManager;
using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            using (ShipmentManager dm = new ShipmentManager())
            {
                foreach (var shipment in shipments)
                {
                    dm.SaveShipment(shipment);
                }
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult ShipmentList()
        {
            using (ShipmentManager dm = new ShipmentManager())
            {
                var models = dm.GetShipmentList();
                return View(models);
            }
        }
    }
}