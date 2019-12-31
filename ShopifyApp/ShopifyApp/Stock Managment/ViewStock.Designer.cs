namespace ShopifyApp.Stock_Managment
{
    partial class ViewStock
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
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.stockItemsDataSet2 = new ShopifyApp.StockItemsDataSet2();
            this.stockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDetailsTableAdapter = new ShopifyApp.StockItemsDataSet2TableAdapters.StockDetailsTableAdapter();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 28);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(776, 410);
            this.dgvView.TabIndex = 0;
            this.dgvView.SelectionChanged += new System.EventHandler(this.dgvView_SelectionChanged);
            // 
            // stockItemsDataSet2
            // 
            this.stockItemsDataSet2.DataSetName = "StockItemsDataSet2";
            this.stockItemsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockDetailsBindingSource
            // 
            this.stockDetailsBindingSource.DataMember = "StockDetails";
            this.stockDetailsBindingSource.DataSource = this.stockItemsDataSet2;
            // 
            // stockDetailsTableAdapter
            // 
            this.stockDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(59, 28);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // ViewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvView);
            this.Name = "ViewStock";
            this.Text = "ViewStock";
            this.Load += new System.EventHandler(this.ViewStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private StockItemsDataSet2 stockItemsDataSet2;
        private System.Windows.Forms.BindingSource stockDetailsBindingSource;
        private StockItemsDataSet2TableAdapters.StockDetailsTableAdapter stockDetailsTableAdapter;
        private System.Windows.Forms.Label lblMessage;
    }
}