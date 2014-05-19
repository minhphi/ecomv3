using System.Collections.Generic;
using System.ServiceModel;
using BusinessObject;

namespace Service
{
    [ServiceContract]
    public interface IActionService
    {
        [OperationContract]
        IList<CmsPage> GetAllPage();
        [OperationContract]
        CmsPage GetPage(int pageId);
        [OperationContract]
        IList<CmsPage> GetListPage(int[] pageIds);
        [OperationContract]
        CmsPage SetPage(CmsPage cmsPage);
        [OperationContract]
        CmsPage UpdatePage(CmsPage page);
        [OperationContract]
        void DeletePage(CmsPage page);
        [OperationContract]
        void DeletePageById(int pageId);
        [OperationContract]
        string Test();
        [OperationContract]
        string GetProductXml(string id);
        [OperationContract]
        string GetProductJson(string id);
        [OperationContract]
        Product GetProduct(int id);
        [OperationContract]
        void InsertProduct(Product obj);
    }
}