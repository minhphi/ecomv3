using System.Collections.Generic;
using System.Linq;
using BusinessObject;
using DataObjects.EntityFramework.Model;

namespace DataObjects.EntityFramework.Implement
{
    public class EntityPageDao : IPageDao
    {
        public IList<CmsPage> FindAll()
        {
            using (var context = DataObjectFactory.CreateDataContext())
            {
                return context.CMS_Page.ToList().Select(Mapper.Map).ToList();
            }
        }

        public CmsPage FindById(int pageId)
        {
            using (var context = DataObjectFactory.CreateDataContext())
            {
                return Mapper.Map(context.CMS_Page.SingleOrDefault(c => c.PageId == pageId));
            }
        }

        public IList<CmsPage> FindBy(int[] pageIds)
        {
            using (var context = DataObjectFactory.CreateDataContext())
            {
                var pages = context.CMS_Page.Where(c => pageIds.Contains(0)).ToList();
                return pages.Select(Mapper.Map).ToList();
            }
        }

        //public List<CmsPage> FindBy(Func<CmsPage, bool> func)
        //{
        //    using (var context = DataObjectFactory.CreateDataContext())
        //    {
        //        return context.CMS_Page.Where(func).ToList();
        //    }
        //}

        public CmsPage Insert(CmsPage page)
        {
            using (var context = DataObjectFactory.CreateDataContext())
            {
                var entity = Mapper.Map(page);
                context.CMS_Page.Add(entity);
                context.SaveChanges();
                return Mapper.Map(entity);
            }
        }

        public IList<CmsPage> Insert(List<CmsPage> pages)
        {
            using (var context = DataObjectFactory.CreateDataContext())
            {
                var entities = pages.Select(Mapper.Map).ToList();
                entities.ForEach(c => context.CMS_Page.Add(c));
                context.SaveChanges();
                return entities.Select(Mapper.Map).ToList();
            }
        }

        public CmsPage Update(CmsPage page)
        {
            using (var context = DataObjectFactory.CreateDataContext())
            {
                var entity = context.CMS_Page.SingleOrDefault(c => c.PageId == page.PageId);
                Mapper.MapNewValue(entity, page);
                // incase entity was modified outside context scope
                // we must mark entity as modified
                // context.Entry(entity).State = System.Data.EntityState.Modified;

                // in this case we modified entity in context scope
                // just save change
                context.SaveChanges();
                return Mapper.Map(entity);
            }
        }

        public List<CmsPage> Update(List<CmsPage> pages)
        {
            using (var context = DataObjectFactory.CreateDataContext())
            {
                List<int> pageIds = pages.Select(c => c.PageId).ToList();
                var entities = context.CMS_Page.Where(c => pageIds.Contains(c.PageId)).ToList();
                foreach (var item in entities)
                {
                    var source = pages.FirstOrDefault(c => c.PageId == item.PageId);
                    if (source != null)
                    {
                        Mapper.MapNewValue(item, source);
                        // case out of scope
                        //context.Entry(item).State = System.Data.EntityState.Modified;
                    }
                }
                context.SaveChanges();
                return entities.Select(Mapper.Map).ToList();
            }
        }

        public void Delete(int pageId)
        {
            using (var context = DataObjectFactory.CreateDataContext())
            {
                var entity = context.CMS_Page.FirstOrDefault(c => c.PageId == pageId);
                context.CMS_Page.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Delete(CmsPage page)
        {
            Delete(page.PageId);
        }

        public void Delete(List<CmsPage> pages)
        {
            Delete(pages.Select(c => c.PageId).ToArray());
        }

        public void Delete(int[] pageIds)
        {
            using (var context = DataObjectFactory.CreateDataContext())
            {
                var entities = context.CMS_Page.Where(c => pageIds.Contains(c.PageId)).ToList();
                entities.ForEach(c => context.CMS_Page.Remove(c));
                context.SaveChanges();
            }
        }
    }
}
