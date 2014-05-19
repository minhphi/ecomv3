using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Serialization;
using BusinessObject;
using DataObjects;
using System.Runtime.Serialization;

namespace Service
{
    public class ActionService : IActionService
    {
        private static IPageDao _pageDao = DataAccess.PageDao;
        private static IProductDao _productDao = DataAccess.ProductDao;

        public IList<CmsPage> GetAllPage()
        {
            return _pageDao.FindAll();
        }
        public CmsPage GetPage(int pageId)
        {
            return _pageDao.FindById(pageId);
        }
        public IList<CmsPage> GetListPage(int[] pageIds)
        {
            return _pageDao.FindBy(pageIds);
        }

        //public CmsPage SetPage(PageRequest pageRequest)
        //{
        //    var cmsPage = new CmsPage
        //                      {
        //                          CreateBy = pageRequest.CreateBy,
        //                          CreateDate = pageRequest.CreateDate,
        //                          IsDelete = pageRequest.IsDelete,
        //                          MasterFileSource = pageRequest.MasterFileSource,
        //                          PageDescribe = pageRequest.PageDescribe,
        //                          PageId = pageRequest.PageId,
        //                          PageLanguage = pageRequest.PageLanguage,
        //                          PageMetadata = pageRequest.PageMetadata,
        //                          PageParentId = pageRequest.PageParentId,
        //                          PageTitle = pageRequest.PageTitle,
        //                          PageView = pageRequest.PageView,
        //                          CacheTime = pageRequest.CacheTime,
        //                          Visible = pageRequest.Visible
        //                      };
        //    _pageDao.Insert(cmsPage);
        //    return cmsPage;
        //}
        public CmsPage SetPage(CmsPage cmsPage)
        {
            return _pageDao.Insert(cmsPage);
        }
        public CmsPage UpdatePage(CmsPage page)
        {
            return _pageDao.Update(page);
        }
        public void DeletePage(CmsPage page)
        {
            _pageDao.Delete(page);
        }
        public void DeletePageById(int pageId)
        {
            _pageDao.Delete(pageId);
        }

        public string Test()
        {
            return "service is running";
        }

        public string GetProductXml(string id)
        {
            var p = GetProduct(Convert.ToInt32(id));
            //var stringwriter = new System.IO.StringWriter();
            //var serializer = new XmlSerializer(p.GetType());
            //serializer.Serialize(stringwriter, p);
            //return stringwriter.ToString();

            XmlDocument xmlDoc = new XmlDocument();   //Represents an XML document, 
            // Initializes a new instance of the XmlDocument class.          
            XmlSerializer xmlSerializer = new XmlSerializer(p.GetType());
            // Creates a stream whose backing store is memory. 
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, p);
                xmlStream.Position = 0;
                //Loads the XML document from the specified string.
                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml;
            }
        }

        public string GetProductJson(string id)
        {
            var p = GetProduct(Convert.ToInt32(id));
            MemoryStream stream = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof(Product));
            ser.WriteObject(stream, p);
            var json = new JavaScriptSerializer().Serialize(p);
            return json;
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
