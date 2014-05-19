using System.Collections.Generic;
using BusinessObject;
using DataObjects;

namespace Service
{
    public class ActionService
    {
        private static IPageDao _pageDao = DataAccess.PageDao;

        public IList<CmsPage> GetAllPage()
        {
            return _pageDao.FindAll();
        }
        public CmsPage GetPage(int pageId)
        {
            return _pageDao.FindById(pageId);
        }
        public IList<CmsPage> GetPage(int[] pageIds)
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
        public void DeletePage(int pageId)
        {
            _pageDao.Delete(pageId);
        }
    }
}
