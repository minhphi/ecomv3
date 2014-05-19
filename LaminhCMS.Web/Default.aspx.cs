using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LaminhCMS.Framework;

namespace LaminhCMS.Web
{
    public partial class Default : PageBase
    {
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.MasterPageFile = "/Skin/Site1.Master";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            //int count = 0;
            //foreach (Control control in this.Controls)
            //{
            //    if (control.GetType().Name == "PlaceHolder")
            //    {
            //        count++;
            //    }
            //}

            IList<Control> allPlaceHolderControl = FindControlsOfType(this, typeof(PlaceHolder));
            WriteAllControlId(Response, allPlaceHolderControl);
            //Control crt = Controls[0];
            //foreach (Control item in crt.Controls)
            //{
            //    if (item.GetType().Name.ToLower().Contains("form"))
            //    {
            //        WriteAllControlId(Response, item.Controls);
            //    }
            //}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //int count = this.Controls.Count;
            //WriteLine(Response, "First level control");
            //for (int i = 0; i < this.Controls.Count; i++)
            //{
            //    WriteLine(Response, this.Controls[i].GetType().Name);
            //}

            //WriteLine(Response, "Second level child");
            //foreach (Control control in this.Controls)
            //{
            //    WriteLine(Response, "Child of : " + control.GetType().Name);
            //    foreach (Control ctr in control.Controls)
            //    {
            //        WriteLine(Response, ctr.GetType().Name);
            //    }
            //}
            //Response.Write("Testing..");
        }

        protected void WriteAllControlId(HttpResponse res, ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                WriteLine(res, control.ID);
            }
        }
        protected void WriteAllControlId(HttpResponse res, IList<Control> controls)
        {
            foreach (Control control in controls)
            {
                WriteLine(res, control.ID);
            }
        }
        protected void WriteLine(HttpResponse res, string text)
        {
            Response.Write(text);
            Response.Write("</br>");
        }

        protected IList<Control> FindControlsOfType(Control contaier, Type type)
        {
            IList<Control> resutls = new List<Control>();
            TravelTreeToFindcontrol(resutls, contaier, type);
            return resutls;
        }

        protected IList<Control> TravelTreeToFindcontrol(IList<Control> results, Control container, Type type)
        {
            if (container.Controls.Count == 0) return results;
            foreach (Control item in container.Controls)
            {
                if (item.GetType() == type)
                {
                    results.Add(item);
                }
                if (item.Controls.Count > 0)
                {
                    TravelTreeToFindcontrol(results, item, type);
                }
            }
            return results;
        }
    }
}