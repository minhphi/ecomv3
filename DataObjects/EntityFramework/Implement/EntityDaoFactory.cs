namespace DataObjects.EntityFramework.Implement
{
    public class EntityDaoFactory : IDaoFactory
    {
        public IPageDao PageDao
        {
            get
            {
                return new EntityPageDao();
            }
        }
        public IProductDao ProductDao
        {
            get
            {
                return new EntityProductDao();
            }
        }
    }
}
