namespace ShopifyApp
{
    partial class StoreDetailsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mangingStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockDetailsToolStripMenuItem,
            this.supplierDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockDetailsToolStripMenuItem
            // 
            this.stockDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mangingStockToolStripMenuItem});
            this.stockDetailsToolStripMenuItem.Name = "stockDetailsToolStripMenuItem";
            this.stockDetailsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.stockDetailsToolStripMenuItem.Text = "Stock Details";
            this.stockDetailsToolStripMenuItem.Click += new System.EventHandler(this.stockDetailsToolStripMenuItem_Click_1);
            // 
            // supplierDetailsToolStripMenuItem
            // 
            this.supplierDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.supplierDetailsToolStripMenuItem.Name = "supplierDetailsToolStripMenuItem";
            this.supplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.supplierDetailsToolStripMenuItem.Text = "Supplier Details";
            this.supplierDetailsToolStripMenuItem.Click += new System.EventHandler(this.supplierDetailsToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "View Stock";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mangingStockToolStripMenuItem
            // 
            this.mangingStockToolStripMenuItem.Name = "mangingStockToolStripMenuItem";
            this.mangingStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mangingStockToolStripMenuItem.Text = "Manging Stock";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageToolStripMenuItem.Text = "Manage Details";
            // 
            // StoreDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 651);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StoreDetailsPage";
            this.Text = "StoreDetailsPage";
            this.Load += new System.EventHandler(this.StoreDetailsPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mangingStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
    }
}