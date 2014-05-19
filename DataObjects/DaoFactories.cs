using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataObjects.EntityFramework.Implement;

namespace DataObjects
{
    public class DaoFactories
    {
        public static IDaoFactory GetFactory(string dataProvider)
        {
            switch (dataProvider)
            {
                case "EntityFramework.SqlServer":
                    return new DataObjects.EntityFramework.Implement.EntityDaoFactory();
                default:
                    return new DataObjects.EntityFramework.Implement.EntityDaoFactory();
            }
        }
    }
}
