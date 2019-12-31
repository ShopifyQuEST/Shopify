using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopifyBLL.ShopifyBL;

namespace ShopifyApp.Stock_Managment
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        private void LoadSuppliers()
        {
            DataSet dsSuppliers = null;
            try
            {
                dsSuppliers = ShopifyItemsBLL.GetSupplierDetails();
                if (dsSuppliers != null)
                {
                    dgvSupplier.DataSource = dsSuppliers.Tables[0];


                    //comboBox1.ValueMember = "Id";
                    //comboBox1.DisplayMember = "Id";

                }
                else
                {
                    lblmessageSupplier.Text = "No supplier avialbale";
                }
            }
            catch (Exception ex)
            {
                lblmessageSupplier.Text = ex.Message.ToString();

            }
        }

        private void View_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }
    }
}
