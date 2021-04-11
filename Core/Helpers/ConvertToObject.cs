using Kovan.Core.DataManager;
using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kovan.Core.Helpers
{
    public static class ConvertToObject
    {
        public static DepotModel DepotModel(this tDepot item)
        {
            return new DepotModel
            {
                Id = item.Id,
                Code = item.Code,
                Name = item.Name
            };
        }
        public static tDepot DepotEntity(this DepotModel item)
        {
            return new tDepot
            {
                Id = item.Id,
                Code = item.Code,
                Name = item.Name
            };
        }
    }
}