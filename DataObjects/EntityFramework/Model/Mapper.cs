using System;
using BusinessObject;

namespace DataObjects.EntityFramework.Model
{
    public class Mapper
    {
        #region CMS Page
        /// <summary>
        /// create new domain object from entity
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static CmsPage Map(CMS_Page obj)
        {
            return new CmsPage
                       {
                           CacheTime = obj.CacheTime ?? 0,
                           CreateBy = obj.CreateBy,
                           CreateDate = obj.CreateDate ?? new DateTime(1900, 1, 1),
                           IsDelete = obj.IsDelete ?? false,
                           MasterFileSource = obj.MasterFileSource,
                           PageDescribe = obj.PageDescribe,
                           PageId = obj.PageId,
                           PageLanguage = obj.PageLanguage,
                           PageMetadata = obj.PageMetadata,
                           PageParentId = obj.PageParentId,
                           PageTitle = obj.PageTitle,
                           PageView = obj.PageView ?? 0,
                           Visible = obj.Visible ?? false
                       };
        }
        /// <summary>
        /// Create new entity object from domain
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static CMS_Page Map(CmsPage obj)
        {
            return new CMS_Page
            {
                CacheTime = obj.CacheTime,
                CreateBy = obj.CreateBy,
                CreateDate = obj.CreateDate,
                IsDelete = obj.IsDelete,
                MasterFileSource = obj.MasterFileSource,
                PageDescribe = obj.PageDescribe,
                PageId = obj.PageId,
                PageLanguage = obj.PageLanguage,
                PageMetadata = obj.PageMetadata,
                PageParentId = obj.PageParentId,
                PageTitle = obj.PageTitle,
                PageView = obj.PageView,
                Visible = obj.Visible
            };
        }
        /// <summary>
        /// Map new value from domain object to entity object
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        public static void MapNewValue(CMS_Page target, CmsPage source)
        {
            target.CacheTime = source.CacheTime;
            target.CreateBy = source.CreateBy;
            target.CreateDate = source.CreateDate;
            target.IsDelete = source.IsDelete;
            target.MasterFileSource = source.MasterFileSource;
            target.PageDescribe = source.PageDescribe;
            target.PageLanguage = source.PageLanguage;
            target.PageMetadata = source.PageMetadata;
            target.PageParentId = source.PageParentId;
            target.PageTitle = source.PageTitle;
            target.PageView = source.PageView;
            target.Visible = source.Visible;
        }
        /// <summary>
        /// Map new value from entity object to domain object
        /// </summary>
        /// <param name="target"></param>
        /// <param name="source"></param>
        public static void MapNewValue(CmsPage target, CMS_Page source)
        {
            target.CacheTime = source.CacheTime ?? 0;
            target.CreateBy = source.CreateBy;
            target.CreateDate = source.CreateDate ?? new DateTime(1900, 1, 1);
            target.IsDelete = source.IsDelete ?? false;
            target.MasterFileSource = source.MasterFileSource;
            target.PageDescribe = source.PageDescribe;
            target.PageLanguage = source.PageLanguage;
            target.PageMetadata = source.PageMetadata;
            target.PageParentId = source.PageParentId;
            target.PageTitle = source.PageTitle;
            target.PageView = source.PageView ?? 0;
            target.Visible = source.Visible ?? false;
        }
        #endregion

        #region product
        public static BusinessObject.Product Map(Product obj)
        {
            return new BusinessObject.Product
                       {
                           CreateDate = obj.CreateDate,
                           Id = obj.Id,
                           Image = obj.Image,
                           Name = obj.Name,
                           Price = obj.Price,
                           ShortDesc = obj.ShortDesc
                       };
        }
        public static Product Map(BusinessObject.Product obj)
        {
            return new Product
                       {
                           CreateDate = obj.CreateDate,
                           Id = obj.Id,
                           Image = obj.Image,
                           Name = obj.Name,
                           Price = obj.Price,
                           ShortDesc = obj.ShortDesc
                       };
        }
        public static void MapNewValue(BusinessObject.Product target, Product source)
        {
            target.CreateDate = source.CreateDate;
            target.Id = source.Id;
            target.Image = source.Image;
            target.Name = source.Name;
            target.Price = source.Price;
            target.ShortDesc = source.ShortDesc;
        }
        public static void MapNewValue(Product target, BusinessObject.Product source)
        {
            target.CreateDate = source.CreateDate;
            target.Id = source.Id;
            target.Image = source.Image;
            target.Name = source.Name;
            target.Price = source.Price;
            target.ShortDesc = source.ShortDesc;
        }
        #endregion
    }
}
