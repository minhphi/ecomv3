using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LaminhCMS.Framework
{
    public class PageBase : System.Web.UI.Page
    {
        public int PageId { get; set; }
        public string MetaData { get; set; }
    }
}
