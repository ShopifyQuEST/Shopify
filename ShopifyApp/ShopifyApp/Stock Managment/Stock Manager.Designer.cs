namespace ShopifyApp.Stock_Managment
{
    partial class Stock_Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStockDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockDetailsToolStripMenuItem,
            this.supplierDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockDetailsToolStripMenuItem
            // 
            this.stockDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stockDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStockDetails,
            this.manageStockDetails});
            this.stockDetailsToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stockDetailsToolStripMenuItem.Name = "stockDetailsToolStripMenuItem";
            this.stockDetailsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.stockDetailsToolStripMenuItem.Text = "Stock Details";
            this.stockDetailsToolStripMenuItem.Click += new System.EventHandler(this.stockDetailsToolStripMenuItem_Click);
            // 
            // viewStockDetails
            // 
            this.viewStockDetails.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewStockDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewStockDetails.Name = "viewStockDetails";
            this.viewStockDetails.Size = new System.Drawing.Size(180, 22);
            this.viewStockDetails.Text = "View";
            this.viewStockDetails.Click += new System.EventHandler(this.viewStockDetails_Click);
            // 
            // manageStockDetails
            // 
            this.manageStockDetails.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manageStockDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.manageStockDetails.Name = "manageStockDetails";
            this.manageStockDetails.Size = new System.Drawing.Size(180, 22);
            this.manageStockDetails.Text = "Manage Stock";
            this.manageStockDetails.Click += new System.EventHandler(this.manageStockDetails_Click);
            // 
            // supplierDetailsToolStripMenuItem
            // 
            this.supplierDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supplierDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSupplier,
            this.manageSupplier});
            this.supplierDetailsToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.supplierDetailsToolStripMenuItem.Name = "supplierDetailsToolStripMenuItem";
            this.supplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.supplierDetailsToolStripMenuItem.Text = "Supplier Details";
            this.supplierDetailsToolStripMenuItem.Click += new System.EventHandler(this.supplierDetailsToolStripMenuItem_Click);
            // 
            // viewSupplier
            // 
            this.viewSupplier.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewSupplier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewSupplier.Name = "viewSupplier";
            this.viewSupplier.Size = new System.Drawing.Size(180, 22);
            this.viewSupplier.Text = "View";
            this.viewSupplier.Click += new System.EventHandler(this.viewSupplier_Click);
            // 
            // manageSupplier
            // 
            this.manageSupplier.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manageSupplier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.manageSupplier.Name = "manageSupplier";
            this.manageSupplier.Size = new System.Drawing.Size(180, 22);
            this.manageSupplier.Text = "Manage ";
            this.manageSupplier.Click += new System.EventHandler(this.manageSupplier_Click);
            // 
            // Stock_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::ShopifyApp.Properties.Resources.maxresdefault1;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Stock_Manager";
            this.Text = "Stock_Manager";
            this.Load += new System.EventHandler(this.Stock_Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockDetails;
        private System.Windows.Forms.ToolStripMenuItem manageStockDetails;
        private System.Windows.Forms.ToolStripMenuItem supplierDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSupplier;
        private System.Windows.Forms.ToolStripMenuItem manageSupplier;
    }
}