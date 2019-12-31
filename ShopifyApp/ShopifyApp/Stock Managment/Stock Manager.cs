using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopifyApp.Stock_Managment
{
    public partial class Stock_Manager : Form
    {
        public Stock_Manager()
        {
            InitializeComponent();
        }

        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewStockDetails_Click(object sender, EventArgs e)
        {
            ViewStock viewStock = new ViewStock();
            viewStock.Show();
            viewStock.MdiParent = this;

        }

        private void Stock_Manager_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void manageStockDetails_Click(object sender, EventArgs e)
        {
           ManageStock manageStock= new ManageStock();
            manageStock.Show();
            manageStock.MdiParent = this;

        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageSupplier_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.Show();
            manage.MdiParent = this;
        }

        private void viewSupplier_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            view.MdiParent = this;
        }
    }
}
