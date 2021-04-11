using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kovan.Models
{
    public class ShipmentModel: BaseModel
    {
        public int OriginDepotId { get; set; }
        public int TargetDepotId { get; set; }
        public int MaterialId { get; set; }
        public int Amount { get; set; }
        public DateTime ShipmentDate { get; set; } = DateTime.Now;
      
    }
}