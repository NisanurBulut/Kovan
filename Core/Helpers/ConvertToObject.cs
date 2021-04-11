using Kovan.Core.DataManager;
using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kovan.Core.Helpers
{
    public static class ConvertToObject
    {
        #region DEPOT 
        public static SelectListItem SelectModel(this tDepot item)
        {
            return new SelectListItem
            {
                Value = item.Id.ToString(),
                Text = item.Name
            };
        }
        public static SelectListItem SelectModel(this tMaterial item)
        {
            return new SelectListItem
            {
                Value = item.Id.ToString(),
                Text = item.Code
            };
        }
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
        #endregion

        #region MATERIAL
        public static MaterialModel MaterialModel(this tMaterial item)
        {
            return new MaterialModel
            {
                Id = item.Id,
                Code = item.Code,
                Description = item.Description,
                Unit = item.Unit
            };
        }
        public static tMaterial MaterialEntity(this MaterialModel item)
        {
            return new tMaterial
            {
                Id = item.Id,
                Code = item.Code,
                Description = item.Description,
                Unit = item.Unit
            };
        }
        #endregion
    }
}