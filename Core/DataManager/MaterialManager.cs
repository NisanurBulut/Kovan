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
        public string SaveMaterial(MaterialModel model)
        {
            var materialEntity = model.MaterialEntity();
            dc.tMaterials.InsertOnSubmit(materialEntity);
            dc.SubmitChanges();
            return "İşlem Başarılı";
        }
    }
}