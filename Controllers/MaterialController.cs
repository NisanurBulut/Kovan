using Kovan.Core.DataManager;
using Kovan.Models;
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
        [HttpGet]
        public ActionResult addMaterial()
        {
            return PartialView(new MaterialModel());
        }
        [HttpPost]
        public ActionResult addMaterial(MaterialModel MaterialModel)
        {
            using (MaterialManager dm = new MaterialManager())
            {
                 dm.SaveMaterial(MaterialModel);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult editMaterial(int id)
        {
            using (MaterialManager dm = new MaterialManager())
            {
                var model = dm.GetMaterial(id);
                return PartialView(model);
            }
        }
        [HttpPost]
        public ActionResult editMaterial(MaterialModel MaterialModel)
        {
            using (MaterialManager dm = new MaterialManager())
            {
                dm.UpdateMaterial(MaterialModel);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult deleteMaterial(int id)
        {
            using (MaterialManager dm = new MaterialManager())
            {
                var model = dm.GetMaterial(id);
                return PartialView(model);
            }
        }
        [HttpDelete]
        public ActionResult destroyMaterial(int id)
        {
            using (MaterialManager dm = new MaterialManager())
            {
                dm.DeleteMaterial(id);
            }
            return RedirectToAction("Index");
        }
    }
}