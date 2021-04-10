using System.Configuration;

namespace Kovan.Core.DataManager
{
    public partial class dbKovanDataContext
    {
        public dbKovanDataContext()
            : base(ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
    }
}