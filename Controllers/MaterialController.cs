using Kovan.Core.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kovan.Controllers
{
    public class MaterialController : Controller
    {
        // GET: Material
        public ActionResult Index()
        {
            using (MaterialManager dm = new MaterialManager())
            {
                return View(dm.GetMaterials());
            }
        }
    }
}