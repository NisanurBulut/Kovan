using Kovan.Core.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kovan.Controllers
{
    public class DepotController : Controller
    {
        // GET: Depot
        public ActionResult Index()
        {
            using (DepotManager dm = new DepotManager())
            {
                return View(dm.GetDepots());
            }            
        }
        [HttpGet]
        public ActionResult editDepot(int id)
        {
            using (DepotManager dm = new DepotManager())
            {
                var model = dm.GetDepot(id);
                return PartialView(model);
            }
        }
    }
}