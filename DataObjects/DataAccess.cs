using System.Configuration;

namespace DataObjects
{
    public class DataAccess
    {
        private static readonly string ConnectionStringName = ConfigurationManager.AppSettings.Get("ConnectionStringName");
        private static readonly IDaoFactory Factory = DaoFactories.GetFactory(ConnectionStringName);

        public static IPageDao PageDao
        {
            get { return Factory.PageDao; }
        }
        public static IProductDao ProductDao
        {
            get { return Factory.ProductDao; }
        }
    }
}
