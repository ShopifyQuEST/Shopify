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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            int output = 0;
            SupplierData supplierData = null;
            try
            {


                supplierData = new SupplierData();
                supplierData.SupplierId = txtSupplierID.Text;
                supplierData.SupplierName = txtSupplierName.Text;
                supplierData.ContactNumber = Convert.ToInt64(txtContact.Text);
               
                supplierData.Desciption = txtDescription.Text;
                output = ShopifyItemsBLL.SupplierAdd(supplierData);
                if (output > 0)

                {
                    lblShow.Text = "successfully added";
                    LoadSupplierID();
                    //LoadContacts();
                    //btnsave.Text = "New";

                    //btndlt.Enabled = true;
                    //btnupdate.Enabled = true;
                    //btnclear.Text = "CLEAR";
                }
                else
                {
                    lblShow.Text = "failed to insert";
                }

            }

            catch (Exception e1)
            {
                lblShow.Text = e1.Message.ToString();
            }


        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
                SupplierData supplierData = null;
                int output = 0;
                try
                {
                    supplierData = new SupplierData();
                     supplierData.SupplierId = txtSupplierID.Text;



                    supplierData.SupplierName = txtSupplierName.Text;

                   supplierData.ContactNumber = Convert.ToInt64(txtContact.Text);

                  

                output = ShopifyItemsBLL.SupplierUpdate(supplierData);


                    if (output > 0)

                    {
                        lblShow.Text = "successfully updated";
                        //LoadContacts();


                    }
                    else
                    {
                        lblShow.Text = "failed to update";
                    }


                }
                catch (Exception e4)
                {
                    lblShow.Text = e4.Message.ToString();
                }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadSupplierID();
        }


        private void LoadSupplierID()
        {
            DataSet dsSuppliers = null;
            try
            {
                dsSuppliers = ShopifyItemsBLL.GetSupplierIDs();
                if (dsSuppliers != null)
                {
                    cmbSearchSupplierID.DataSource = dsSuppliers.Tables[0];


                    cmbSearchSupplierID.ValueMember = "SupplierID";
                    cmbSearchSupplierID.DisplayMember = "SupplierID";

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

        private void cmbSearchSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplierData supplierData = null;
            try
            {
                supplierData = ShopifyItemsBLL.GetBySupplierID(cmbSearchSupplierID.Text);
                if (supplierData != null)
                {
                    txtSupplierID.Text = supplierData.SupplierId;

                    txtSupplierName.Text = supplierData.SupplierName;
                    txtContact.Text = supplierData.ContactNumber.ToString();
                    txtDescription.Text = supplierData.Desciption;


                }

            }

            catch (Exception e5)
            {
                labelMessage.Text = e5.Message.ToString();
            }
        }

        private void btnDeleting_Click(object sender, EventArgs e)
        {
            int output = 0;
            try
            {
                if (MessageBox.Show("DO YOU WANT TO DELETE ? ", "S I S",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    output = ShopifyItemsBLL.DeletingItem(cmbSearchSupplierID.Text);
                }
                if (output > 0)
                {
                    lblShow.Text = " details deleted succesfully";
                    //LoadContacts();
                    LoadSupplierID();

                }
                else
                {
                    lblShow.Text = "try again later";
                }
            }
            catch (Exception e7)
            {
                lblShow.Text = e7.Message.ToString();
            }
        }
    }
}
