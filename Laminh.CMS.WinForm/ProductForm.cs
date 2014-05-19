using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Laminh.CMS.WinForm.Product;

namespace Laminh.CMS.WinForm
{
    public partial class ProductForm : Form
    {
        //AddNewProduct addNewProductForm = new AddNewProduct();
        public ProductForm()
        {
            InitializeComponent();
            //addNewProductForm.MdiParent = this;
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addNewProductForm = new AddNewProduct();
            addNewProductForm.MdiParent = this;
            addNewProductForm.Show();
        }

        private void testServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var main = new Main();
            main.MdiParent = this;
            main.Show();
        }
    }
}
