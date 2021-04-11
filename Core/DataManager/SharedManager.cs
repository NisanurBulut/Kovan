using Kovan.Core.Helpers;
using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kovan.Core.DataManager
{
    public class SharedManager:DataAccessObject
    {
        public List<SelectModel> GetSelectDepots()
        {
            return dc.tDepots.Select(a => a.SelectModel()).ToList();
        }
        public List<SelectModel> GetSelectMaterials()
        {
            return dc.tMaterials.Select(a => a.SelectModel()).ToList();
        }
    }
}