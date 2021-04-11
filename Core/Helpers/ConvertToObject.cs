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
        #region SHIPMENT
        public static ShipmentModel ShipmentModel(this tShipment item)
        {
            return new ShipmentModel
            {
                Id = item.Id,
                ShipmentDate = item.ShipmentDate,
                OriginDepotId = item.OriginDepotId,
                TargetDepotId = item.TargetDepotId,
                MaterialId = item.MaterialId,
                Amount= item.Amount
            };
        }
        public static tShipment ShipmentEntity(this ShipmentModel item)
        {
            return new tShipment
            {
                Id = item.Id,
                ShipmentDate = item.ShipmentDate,
                OriginDepotId = item.OriginDepotId,
                TargetDepotId = item.TargetDepotId,
                MaterialId = item.MaterialId,
                Amount = item.Amount
            };
        }
        #endregion
        #region SHARED
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
        #endregion
        #region DEPOT      
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