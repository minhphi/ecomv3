using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataObjects.EntityFramework.Model;

namespace DataObjects.EntityFramework.Implement
{
    public abstract class EntityDaoBase
    {
        protected LaminhCMSEntities Context { get { return DataObjectFactory.CreateDataContext(); } }
    }
}
