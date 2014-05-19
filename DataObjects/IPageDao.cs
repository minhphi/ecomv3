using System.Collections.Generic;
using BusinessObject;

namespace DataObjects
{
    public interface IPageDao
    {
        IList<CmsPage> FindAll();
        CmsPage FindById(int pageId);
        IList<CmsPage> FindBy(int[] pageIds);
        //List<CmsPage> FindBy(Func<CmsPage, bool> func);

        CmsPage Insert(CmsPage page);
        IList<CmsPage> Insert(List<CmsPage> pages);

        CmsPage Update(CmsPage page);
        List<CmsPage> Update(List<CmsPage> pages);

        void Delete(int pageId);
        void Delete(CmsPage page);
        void Delete(List<CmsPage> pages);
        void Delete(int[] pageIds);
    }
}
