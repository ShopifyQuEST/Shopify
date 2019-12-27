using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopifyDTO.DTO;
using ShopifyBLL.ShopifyBL;


namespace ShopifyApp.Stock_Managment
{
    public partial class ManageStock : Form
    {
        public ManageStock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertStock_Click(object sender, EventArgs e)
        {


            int output = 0;
            ShopifyItems shopifyItems = null;
            try
            {


                shopifyItems = new ShopifyItems();
                shopifyItems.Productid = txtProductID.Text;
                shopifyItems.Productname =txtProductName.Text;
                shopifyItems.Unitprice =Convert.ToInt64(txtUnitPrice.Text);
                shopifyItems.Quantity = Convert.ToInt64(txtQuality.Text);
                shopifyItems.Supplierid = cmbSupplierID.Text;
                output = ShopifyItemsBLL.StockInsert(shopifyItems);
                if (output > 0)

                {
                    labelMessage.Text = "successfully added";
                    //LoadContacts();
                    //LoadContacts();
                    //btnsave.Text = "New";

                    //btndlt.Enabled = true;
                    //btnupdate.Enabled = true;
                    //btnclear.Text = "CLEAR";




                }
                else
                {
                    labelMessage.Text = "failed to insert";
                }

            }

            catch (Exception e1)
            {
                labelMessage.Text = e1.Message.ToString();
            }





        }
    }
}
