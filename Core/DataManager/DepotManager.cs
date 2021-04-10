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
    }
}