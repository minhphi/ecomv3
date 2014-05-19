using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject.BusinessRules;

namespace BusinessObject
{
    public class CmsPage : BusinessObject
    {
        public int PageId { get; set; }
        public string PageTitle { get; set; }
        public string PageMetadata { get; set; }
        public string PageDescribe { get; set; }
        public int CacheTime { get; set; }
        public string MasterFileSource { get; set; }
        public string PageLanguage { get; set; }
        public bool Visible { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string PageParentId { get; set; }
        public int PageView { get; set; }
        public bool IsDelete { get; set; }

        public CmsPage()
        {
            AddRule(new ValidateId("PageId"));
        }
    }
}
