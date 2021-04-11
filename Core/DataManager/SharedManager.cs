using Kovan.Core.Helpers;
using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kovan.Core.DataManager
{
    public class SharedManager:DataAccessObject
    {
        public List<SelectListItem> GetSelectDepots()
        {
            return dc.tDepots.Select(a => a.SelectModel()).ToList();
        }
        public List<SelectListItem> GetSelectMaterials()
        {
            return dc.tMaterials.Select(a => a.SelectModel()).ToList();
        }
    }
}