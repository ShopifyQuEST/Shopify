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

namespace ShopifyApp.Cashier
{
    public partial class SalesBilling : Form
    {
        public SalesBilling()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CashierMenu objCM = new CashierMenu();
            //objSB.MdiParent = this.MdiParent;
            this.Hide();
            objCM.Show();
        }




        private void ClearControl()
        {
            lblMessage.Text = "";

            txtProductId.Text = "";
            txtProductName.Text = "";
            txtProductQuantity.Text = "";
            txtTotal.Text = "";
            txtUnitPrice.Text = "";
        }



        private void LoadSalesHistoryGrid()
        {
            DataSet Sales = null;
            try
            {

                Sales = ShopifyItemsBLL.GetSalesBL(txtSalesId.Text);

                if (Sales != null)
                {
                    dgvSalesHistory.DataSource = Sales.Tables[0];

                }
                else
                {
                    lblMessage.Text = "no item  is available";
                }

            }
            catch (Exception ef)
            {
                lblMessage.Text = ef.Message.ToString();
            }
        }






        public static String GetNewSalesId()
        {
            string NewSalesId = null;

            try
            {
                NewSalesId = ShopifyItemsBLL.GetLastSalesId();
            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : StudentMarkBl.cs:GetNewStudentId:" + exe.Message.ToString());
            }

            return NewSalesId;
        }








        private void btnNext_Click(object sender, EventArgs e)
        {
            ShopifyItems shopifyItems = null;
            int output = 0;
            try
            {



                if (txtSalesId.Text == string.Empty && txtProductId.Text == string.Empty && txtProductName.Text == string.Empty && txtProductQuantity.Text == string.Empty && txtUnitPrice.Text == string.Empty && txtTotal.Text == string.Empty)
                {
                    lblMessage.Text = "! All fields are mandatory. Enter Data to all fields";
                    return;
                }
                else if (txtSalesId.Text == string.Empty)
                {
                    lblMessage.Text = "! Enter Contact ID";
                    return;
                }
                else if (txtProductId.Text == string.Empty)
                {
                    lblMessage.Text = "! Enter Contact Name";
                    return;
                }
                else if (txtProductName.Text == string.Empty)
                {
                    lblMessage.Text = "! Enter Contact Email";
                    return;
                }
                else if (txtProductQuantity.Text == string.Empty)
                {
                    lblMessage.Text = "! Enter Employee Mobile Number";
                    return;
                }
                else
                {
                    //double totalAmmount;
                    shopifyItems = new ShopifyItems();


                    shopifyItems.Salesid = txtSalesId.Text;
                    shopifyItems.Productid = txtProductId.Text;
                    shopifyItems.Productname = txtProductName.Text;
                    shopifyItems.Quantity = Convert.ToInt64(txtProductQuantity.Text);
                    shopifyItems.Unitprice = Convert.ToInt64(txtUnitPrice.Text);

                    shopifyItems.Salesdate = DateTime.Now.ToString("dd/MM/yyyy");
                   



                    output = ShopifyItemsBLL.SaleEachInsertBL(shopifyItems);


                    if (output > 0)
                    {
                        lblMessage.Text = "Success";
                        LoadSalesHistoryGrid();
                        ClearControl();

                        lblTotal.Text =Convert.ToString(shopifyItems.Total);
                        
                        
                    }
                    else
                    {
                        lblMessage.Text = "Fail";
                    }
                }

            }
            catch (Exception ef)
            {
                lblMessage.Text = ef.Message.ToString();
            }
        }

        private void SalesBilling_Load(object sender, EventArgs e)
        {
            lblDate.Text= DateTime.Now.ToString("dd/MM/yyyy");
            txtSalesId.Text=GetNewSalesId();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            ShopifyItems shopifyItems = null;
            int output = 0;
            try
            {
                shopifyItems = new ShopifyItems();


                shopifyItems.Salesid = txtSalesId.Text;
                shopifyItems.Salesdate = DateTime.Now.ToString("dd/MM/yyyy");

                

                output = ShopifyItemsBLL.SalesInsertBL(shopifyItems);


                if (output > 0)
                {
                    lblMessage.Text = "Success";
                }
                else
                {
                    lblMessage.Text = "Fail";
                }

            }
            catch (Exception exe)
            {
                Console.Out.WriteLine("****error : StudentMarkBl.cs:GetNewStudentId:" + exe.Message.ToString());
            }
        }

        private void dgvSalesHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
