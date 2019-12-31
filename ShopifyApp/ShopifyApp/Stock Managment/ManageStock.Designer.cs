namespace ShopifyApp.Stock_Managment
{
    partial class ManageStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbSupplierID = new System.Windows.Forms.ComboBox();
            this.btnInsertStock = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SEARCH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMessaging = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Supplier ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(200, 17);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(146, 20);
            this.txtProductID.TabIndex = 6;
            this.txtProductID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(200, 109);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(146, 20);
            this.txtUnitPrice.TabIndex = 7;
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(200, 153);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(146, 20);
            this.txtQuality.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(200, 64);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(146, 20);
            this.txtProductName.TabIndex = 10;
            // 
            // cmbSupplierID
            // 
            this.cmbSupplierID.FormattingEnabled = true;
            this.cmbSupplierID.Location = new System.Drawing.Point(200, 203);
            this.cmbSupplierID.Name = "cmbSupplierID";
            this.cmbSupplierID.Size = new System.Drawing.Size(146, 21);
            this.cmbSupplierID.TabIndex = 11;
            // 
            // btnInsertStock
            // 
            this.btnInsertStock.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertStock.Location = new System.Drawing.Point(17, 330);
            this.btnInsertStock.Name = "btnInsertStock";
            this.btnInsertStock.Size = new System.Drawing.Size(103, 32);
            this.btnInsertStock.TabIndex = 12;
            this.btnInsertStock.Text = "ADD ITEM";
            this.btnInsertStock.UseVisualStyleBackColor = true;
            this.btnInsertStock.Click += new System.EventHandler(this.btnInsertStock_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(493, 413);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 13;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(148, 330);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(120, 32);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(302, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbID
            // 
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(490, 16);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(121, 21);
            this.cmbID.TabIndex = 16;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lblMessaging);
            this.panel1.Controls.Add(this.SEARCH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbID);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnInsertStock);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbSupplierID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQuality);
            this.panel1.Location = new System.Drawing.Point(265, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 443);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SEARCH
            // 
            this.SEARCH.AutoSize = true;
            this.SEARCH.Location = new System.Drawing.Point(406, 24);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(64, 13);
            this.SEARCH.TabIndex = 17;
            this.SEARCH.Text = "SearchByID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = global::ShopifyApp.Properties.Resources.finalpicc;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 76);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(1, 658);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1255, 35);
            this.panel3.TabIndex = 19;
            // 
            // lblMessaging
            // 
            this.lblMessaging.AutoSize = true;
            this.lblMessaging.Location = new System.Drawing.Point(197, 269);
            this.lblMessaging.Name = "lblMessaging";
            this.lblMessaging.Size = new System.Drawing.Size(31, 13);
            this.lblMessaging.TabIndex = 18;
            this.lblMessaging.Text = "........";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(932, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "DATE :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(988, 92);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(13, 19);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = ".";
            // 
            // ManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1256, 691);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label2);
            this.Name = "ManageStock";
            this.Text = "ManageStock";
            this.Load += new System.EventHandler(this.ManageStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbSupplierID;
        private System.Windows.Forms.Button btnInsertStock;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SEARCH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMessaging;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label7;
    }
}