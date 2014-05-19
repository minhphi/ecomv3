using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaminhCMS
{
    public class PageNode
    {
        public int PageID { get; set; }
        public List<PageNode> ChildNotes = new List<PageNode>();
        public string Title { get; set; }
    }
}
