using Kovan.Core.Helpers;
using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kovan.Core.DataManager
{
    public class DepotManager:DataAccessObject
    {
        public List<DepotModel> GetDepots()
        {
            return dc.tDepots.Select(a => a.DepotModel()).ToList();
        }
        public DepotModel GetDepot(int id)
        {
            return dc.tDepots.Where(a => a.Id == id).Select(a=>a.DepotModel()).FirstOrDefault() ?? new DepotModel();
        }
        public string SaveDepot(DepotModel model)
        {
            var depotEntity = model.DepotEntity();
            dc.tDepots.InsertOnSubmit(depotEntity);
            dc.SubmitChanges();
            return "İşlem Başarılı";
        }
        public string UpdateDepot(DepotModel model)
        {
            var depotEntity = dc.tDepots.Where(a=>a.Id==model.Id).FirstOrDefault();
            depotEntity.Code = model.Code;
            depotEntity.Name = model.Name;
            dc.SubmitChanges();
            return "İşlem Başarılı";
        }
        public string DeleteDepot(int id)
        {
            var depotEntity = dc.tDepots.Where(a => a.Id == id).FirstOrDefault();
            dc.tDepots.DeleteOnSubmit(depotEntity);
            dc.SubmitChanges();
            return "İşlem Başarılı";
        }
    }
}