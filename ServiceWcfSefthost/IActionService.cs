using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BusinessObject;

namespace ServiceWcfSefthost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IActionService" in both code and config file together.
    [ServiceContract]
    public interface IActionService
    {

        [OperationContract]
        string Test();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "/Productxml/{id}")]
        string GetProductXml(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "/Productjson/{id}")]
        string GetProductJson(string id);

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        void InsertProduct(Product obj);
    }
}
