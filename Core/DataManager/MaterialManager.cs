using Kovan.Core.Helpers;
using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kovan.Core.DataManager
{
    public class MaterialManager : DataAccessObject
    {
        public List<MaterialModel> GetMaterials()
        {
            return dc.tMaterials.Select(a => a.MaterialModel()).ToList();
        }
        public MaterialModel GetMaterial(int id)
        {
            return dc.tMaterials.Where(a => a.Id == id).Select(a => a.MaterialModel()).FirstOrDefault() ?? new MaterialModel();
        }
        public string SaveMaterial(MaterialModel model)
        {
            var materialEntity = model.MaterialEntity();
            dc.tMaterials.InsertOnSubmit(materialEntity);
            dc.SubmitChanges();
            return "İşlem Başarılı";
        }
        public string UpdateMaterial(MaterialModel model)
        {
            var MaterialEntity = dc.tMaterials.Where(a => a.Id == model.Id).FirstOrDefault();
            MaterialEntity.Code = model.Code;
            MaterialEntity.Description = model.Description;
            MaterialEntity.Unit = model.Unit;
            dc.SubmitChanges();
            return "İşlem Başarılı";
        }
        public string DeleteMaterial(int id)
        {
            var MaterialEntity = dc.tMaterials.Where(a => a.Id == id).FirstOrDefault();
            dc.tMaterials.DeleteOnSubmit(MaterialEntity);
            dc.SubmitChanges();
            return "İşlem Başarılı";
        }
    }
}