using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessObject;
using DataObjects;

namespace ServiceWcfSefthost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ActionService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ActionService.svc or ActionService.svc.cs at the Solution Explorer and start debugging.
    public class ActionService : IActionService
    {
        private static IProductDao _productDao = DataAccess.ProductDao;
        public string Test()
        {
            return "service is running";
        }

        public string GetProductXml(string id)
        {
            return "product xml format";
        }

        public string GetProductJson(string id)
        {
            return "product Json format";
        }

        public Product GetProduct(int id)
        {
            return _productDao.FindById(id);
        }

        public void InsertProduct(Product obj)
        {
            _productDao.Insert(obj);
        }
    }
}
