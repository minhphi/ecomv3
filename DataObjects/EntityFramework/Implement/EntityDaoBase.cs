using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataObjects.EntityFramework.Model;

namespace DataObjects.EntityFramework.Implement
{
    public abstract class EntityDaoBase
    {
        protected LaminhCMSEntities _context;
        protected LaminhCMSEntities Context
        {
            //get { return _context ?? (_context = DataObjectFactory.CreateDataContext()); }
            get { return DataObjectFactory.CreateDataContext(); }
        }
    }
}
