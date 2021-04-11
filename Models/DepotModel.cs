using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Kovan.Models
{
    public class DepotModel: BaseModel
    {
        [DisplayName("Depo Kodu")]
        public string Code { get; set; }
        [DisplayName("Depo Adı")]
        public string Name { get; set; }
    }
}