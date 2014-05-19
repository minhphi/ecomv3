using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Laminh.CMS.WinForm.ServiceReference1;

namespace Laminh.CMS.WinForm.Product
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var p = new ServiceReference1.Product();
            string pName = txtName.Text;
            string pShortDes = txtShortDes.Text;
            string pPrice = txtPrice.Text;
            double price = 0.0;
            if (string.IsNullOrEmpty(pName))
            {
                MessageBox.Show("Product Name should not be null or empty");
                return;
            }
            if (!double.TryParse(pPrice, out price))
            {
                MessageBox.Show("Price should be a number");
                return;

            }
            p.Name = pName;
            p.ShortDesc = pShortDes;
            p.CreateDate = DateTime.Now;
            p.Price = price;

            ServiceReference1.ActionServiceClient client = new ActionServiceClient();
            client.InsertProduct(p);
            MessageBox.Show("Add product success.");
            MessageBox.Show("Add product success.");
        }
    }
}
