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
        public List<ShipmentListModel> GetShipmentList()
        {
           return dc.tShipments.Join(dc.tDepots, ts => ts.OriginDepotId, od => od.Id, (ts, od) => new { ts, od })
                .Join(dc.tMaterials, tsm => tsm.ts.MaterialId, tm => tm.Id, (tsm, tm) => new { tsm, tm })
                .Join(dc.tDepots, tsd => tsd.tsm.ts.TargetDepotId, td => td.Id, (tsd, td) => new { tsd, td })
                .Select(a => new ShipmentListModel
                {
                    Id = a.tsd.tsm.ts.Id,
                    Material = a.tsd.tm.Code,
                    Unit = a.tsd.tm.Unit,
                    ShipmentDate = a.tsd.tsm.ts.ShipmentDate,
                    OriginDepot = a.tsd.tsm.od.Name,
                    TargetDepot = a.td.Name
                }).ToList();
        }
    }
}