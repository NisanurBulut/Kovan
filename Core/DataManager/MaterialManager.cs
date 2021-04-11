using Kovan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kovan.Core.DataManager
{
    public class MaterialManager : DataAccessObject
    {
        public List<MaterialModel> GetMaterials()
        {
            return dc.tDepots.Select(a => a.MaterialModel()).ToList();
        }
    }
}