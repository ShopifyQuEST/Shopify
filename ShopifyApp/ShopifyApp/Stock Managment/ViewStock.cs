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
    public partial class ViewStock : Form
    {
        public ViewStock()
        {
            InitializeComponent();
        }

        private void ViewStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockItemsDataSet2.StockDetails' table. You can move, or remove it, as needed.
            this.stockDetailsTableAdapter.Fill(this.stockItemsDataSet2.StockDetails);
            LoadContacts();

        }





        private void LoadContacts()
        {
            DataSet dsStudents = null;
            try
            {
                dsStudents = ShopifyItemsBLL.GetDetails();
                if (dsStudents != null)
                {
                    dgvView.DataSource = dsStudents.Tables[0];


                    //comboBox1.ValueMember = "Id";
                    //comboBox1.DisplayMember = "Id";

                }
                else
                {
                    lblMessage.Text = "No students avialbale";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message.ToString();

            }
        }

        private void dgvView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
