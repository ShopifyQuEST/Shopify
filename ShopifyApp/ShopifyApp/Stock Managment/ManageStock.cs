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




        //Method to insert into Stock

        private void btnInsertStock_Click(object sender, EventArgs e)
        {

            int output = 0;
            ShopifyItems shopifyItems = null;
            try
            {
                if (txtProductID.Text == string.Empty && txtProductName.Text == string.Empty && txtQuality.Text == string.Empty && txtUnitPrice.Text == string.Empty && cmbID.Text == string.Empty)
                {
                    lblMessaging.Text = "! All fields are mandatory. Enter Data to all fields";
                    return;
                }
                else if (txtProductID.Text == string.Empty)
                {
                    lblMessaging.Text = "! Enter Product ID";
                    return;
                }
                else if (txtProductName.Text == string.Empty)
                {
                    lblMessaging.Text = "! Enter Product Name";
                    return;
                }
                else if (txtQuality.Text == string.Empty)
                {
                    lblMessaging.Text = "! Enter Product Quantity";
                    return;
                }
                else if (txtUnitPrice.Text == string.Empty)
                {
                    lblMessaging.Text = "! Enter Unit Price";
                    return;
                }
             
                else
                {


                    shopifyItems = new ShopifyItems();
                    shopifyItems.Productid = txtProductID.Text;
                    shopifyItems.Productname = txtProductName.Text;
                    shopifyItems.Unitprice = Convert.ToInt64(txtUnitPrice.Text);
                    shopifyItems.Quantity = Convert.ToInt64(txtQuality.Text);
                    shopifyItems.Supplierid = cmbSupplierID.Text;
                    shopifyItems.Date = lblDate.Text;
                    output = ShopifyItemsBLL.StockInsert(shopifyItems);
                    if (output > 0)

                    {
                        lblMessaging.Text = "successfully added";
                        LoadContactIDs();
                      
                        //btnsave.Text = "New";

                        //btndlt.Enabled = true;
                        //btnupdate.Enabled = true;
                        //btnclear.Text = "CLEAR";
                    }
                    else
                    {
                        lblMessaging.Text = "failed to insert";
                    }
                }
            }

            catch (Exception e1)
            {
                lblMessaging.Text = e1.Message.ToString();
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

                shopifyItems.Supplierid = cmbSupplierID.Text;
                output = ShopifyItemsBLL.StockUpdate(shopifyItems);


                if (output > 0)

                {
                    lblMessaging.Text = "successfully updated";
                    LoadContactIDs();

                }
                else
                {
                    lblMessaging.Text = "failed to update";
                }


            }
            catch (Exception e4)
            {
                lblMessaging.Text = e4.Message.ToString();
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
                    lblMessaging.Text = " details deleted succesfully";
                    //LoadContacts();
                    LoadContactIDs();

                }
                else
                {
                    lblMessaging.Text = "try again later";
                }
            }
            catch (Exception e7)
            {
                lblMessaging.Text = e7.Message.ToString();
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
            LoadSupplierID();

            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");


        }


        private void LoadContactIDs()
        {
            DataSet dsStockID = null;
            try
            {
                dsStockID = ShopifyItemsBLL.GetProductID();
                if (dsStockID != null)
                {
                    cmbID.DataSource = dsStockID.Tables[0];


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



        private void LoadSupplierID()
        {
            DataSet dsStudentID = null;
            try
            {
                dsStudentID = ShopifyItemsBLL.GetSupplierIDs();
                if (dsStudentID != null)
                {
                    cmbSupplierID.DataSource = dsStudentID.Tables[0];


                    cmbSupplierID.ValueMember = "SupplierID";
                    cmbSupplierID.DisplayMember = "SupplierID";

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
