using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Web;
using DataObjects.EntityFramework.Model;

namespace DataObjects.EntityFramework
{
    public class DataObjectFactory
    {
        private static readonly string DATACONTEXTSTOREKEY = "ENTITYCONTEXTKEY_" + typeof(LaminhCMSEntities).FullName;
        private static readonly string _connectionString;
        static DataObjectFactory()
        {
            string connectionStringName = ConfigurationManager.AppSettings.Get("ConnectionStringName");
            _connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        public static LaminhCMSEntities CreateDataContext()
        {
            LaminhCMSEntities context;
            // in web context
            if (HttpContext.Current != null)
            {
                if (HttpContext.Current.Items[DATACONTEXTSTOREKEY] != null)
                {
                    context = (LaminhCMSEntities)HttpContext.Current.Items[DATACONTEXTSTOREKEY];
                }
                else
                {
                    //context = new LaminhCMSEntities(_connectionString);
                    context = new LaminhCMSEntities();
                    HttpContext.Current.Items[DATACONTEXTSTOREKEY] = context;
                }
            }
            else
            {
                if (CallContext.GetData(DATACONTEXTSTOREKEY) == null)
                {
                    //context = new LaminhCMSEntities(_connectionString);
                    context = new LaminhCMSEntities();
                    CallContext.SetData(DATACONTEXTSTOREKEY, context);
                }
                else
                {
                    context = (LaminhCMSEntities)CallContext.GetData(DATACONTEXTSTOREKEY);
                }
            }
            return context;
        }
    }
}
