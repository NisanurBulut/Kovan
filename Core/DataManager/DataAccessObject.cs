using Kovan.Core.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kovan.Core.DataManager
{
    public class DataAccessObject : IDisposable
    {
        protected dbKovanDataContext dc;

        public DataAccessObject()
        {
            dc = new dbKovanDataContext();
        }
        public void Dispose()
        {
            dc.Dispose();
        }
    }
}