using Kovan.Core.Helpers;
using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kovan.Core.DataManager
{
    public class ShipmentManager : DataAccessObject
    {
        public void SaveShipment(ShipmentModel model)
        {
            tShipment shipmentEntity = model.ShipmentEntity();
            dc.tShipments.InsertOnSubmit(shipmentEntity);
            dc.SubmitChanges();
        }
    }
}