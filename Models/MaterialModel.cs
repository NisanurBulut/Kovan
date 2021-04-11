using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Kovan.Models
{
    public class MaterialModel
    {
        public int Id { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Materyal Kodu")]

        public string Code { get; set; }
        [DisplayName("Materyal Birimi")]

        public string Unit { get; set; }
    }
}