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



namespace ShopifyApp
{
    public partial class StoreDetailsPage : Form
    {
        public StoreDetailsPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void StoreDetailsPage_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;


         
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int output = 0;
            ShopifyItems shopifyItems = null;



        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StockDetailsNExtform stockDetailsNExtform = new StockDetailsNExtform();
            stockDetailsNExtform.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
          
        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void stockDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void supplierDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SupplierDetailsForm supplierDetailsForm = new SupplierDetailsForm();
            supplierDetailsForm.Show();
            supplierDetailsForm.MdiParent = this;
        }

        private void lOgoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockDetailsNExtform stockDetailsNExtform = new StockDetailsNExtform();
            stockDetailsNExtform.Show();
            stockDetailsNExtform.MdiParent = this;
        }
    }
}
