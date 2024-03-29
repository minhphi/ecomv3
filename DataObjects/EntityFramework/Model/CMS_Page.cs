//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataObjects.EntityFramework.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CMS_Page
    {
        public CMS_Page()
        {
            this.CMS_Page_UserControl = new HashSet<CMS_Page_UserControl>();
        }
    
        public int PageId { get; set; }
        public string PageTitle { get; set; }
        public string PageMetadata { get; set; }
        public string PageDescribe { get; set; }
        public Nullable<int> CacheTime { get; set; }
        public string MasterFileSource { get; set; }
        public string PageLanguage { get; set; }
        public Nullable<bool> Visible { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string PageParentId { get; set; }
        public Nullable<int> PageView { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual ICollection<CMS_Page_UserControl> CMS_Page_UserControl { get; set; }
    }
}
