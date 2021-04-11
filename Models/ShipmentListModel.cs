using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kovan.Models
{
    public class ShipmentListModel:BaseModel
    {
        public string OriginDepot { get; set; }
        public string TargetDepot { get; set; }
        public string Material { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }

    }
}