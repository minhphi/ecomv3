using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Laminh.CMS.WinForm.ServiceReference1;

namespace Laminh.CMS.WinForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            textBox1.Text = "not connected";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var actionservice = new ServiceReference1.ActionServiceClient();
            string str = actionservice.Test();
            textBox1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var actionservice = new ServiceReference1.ActionServiceClient();
            textBox1.Text = actionservice.GetProductXml("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var actionservice = new ServiceReference1.ActionServiceClient();
            textBox1.Text = actionservice.GetProductJson("1");
        }
    }
}
