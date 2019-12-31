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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ShopifyItems shopifyItems = null;
            int output = 0;
            try
            {
                shopifyItems = new ShopifyItems();
                shopifyItems.Productid =txtProductID.Text;

                

                shopifyItems.Productname =txtProductName.Text;

                shopifyItems.Unitprice =Convert.ToInt64(txtUnitPrice.Text);

                shopifyItems.Quantity = Convert.ToInt64(txtQuality.Text);

                output = ShopifyItemsBLL.StockUpdate(shopifyItems);


                if (output > 0)

                {
                    labelMessage.Text = "successfully updated";
                    //LoadContacts();


                }
                else
                {
                    labelMessage.Text = "failed to update";
                }


            }
            catch (Exception e4)
            {
                labelMessage.Text = e4.Message.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int output = 0;
            try
            {
                if (MessageBox.Show("DO YOU WANT TO DELETE ? ", "S I S",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    output = ShopifyItemsBLL.DeleteItem(cmbID.Text);
                }
                if (output > 0)
                {
                    labelMessage.Text = " details deleted succesfully";
                    //LoadContacts();
                    //LoadContactIDs();

                }
                else
                {
                    labelMessage.Text = "try again later";
                }
            }
            catch (Exception e7)
            {
                labelMessage.Text = e7.Message.ToString();
            }


        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbID.Text);
            ShopifyItems shopifyItems = null;
            try
            {
                shopifyItems = ShopifyItemsBLL.GetByID(cmbID.Text);
                if (shopifyItems != null)
                {
                    txtProductID.Text = shopifyItems.Productid;

                    txtProductName.Text = shopifyItems.Productname;
                    txtUnitPrice.Text = shopifyItems.Unitprice.ToString();
                    txtQuality.Text =shopifyItems.Quantity.ToString();


                }

            }

            catch (Exception e5)
            {
                labelMessage.Text = e5.Message.ToString();
            }
        }

        private void ManageStock_Load(object sender, EventArgs e)
        {
            LoadContactIDs();
        }


        private void LoadContactIDs()
        {
            DataSet dsStudentID = null;
            try
            {
                dsStudentID = ShopifyItemsBLL.GetContactIDs();
                if (dsStudentID != null)
                {
                    cmbID.DataSource = dsStudentID.Tables[0];


                    cmbID.ValueMember = "ProductID";
                    cmbID.DisplayMember = "ProductID";

                }
                else
                {
                    labelMessage.Text = "No students avialbale";
                }
            }
            catch (Exception ex)
            {
                labelMessage.Text = ex.Message.ToString();

            }
        }

      




    }
}
