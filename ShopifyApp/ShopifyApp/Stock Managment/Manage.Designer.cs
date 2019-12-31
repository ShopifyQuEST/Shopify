namespace ShopifyApp.Stock_Managment
{
    partial class Manage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleting = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.cmbSearchSupplierID = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelMessage);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(233, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 428);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnDeleting);
            this.panel2.Controls.Add(this.lblShow);
            this.panel2.Controls.Add(this.cmbSearchSupplierID);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAddSupplier);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSupplierID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSupplierName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(17, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 387);
            this.panel2.TabIndex = 12;
            // 
            // btnDeleting
            // 
            this.btnDeleting.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleting.Location = new System.Drawing.Point(178, 286);
            this.btnDeleting.Name = "btnDeleting";
            this.btnDeleting.Size = new System.Drawing.Size(86, 31);
            this.btnDeleting.TabIndex = 12;
            this.btnDeleting.Text = "DELETE";
            this.btnDeleting.UseVisualStyleBackColor = true;
            this.btnDeleting.Click += new System.EventHandler(this.btnDeleting_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(220, 227);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(34, 13);
            this.lblShow.TabIndex = 11;
            this.lblShow.Text = ".........";
            // 
            // cmbSearchSupplierID
            // 
            this.cmbSearchSupplierID.FormattingEnabled = true;
            this.cmbSearchSupplierID.Location = new System.Drawing.Point(507, 25);
            this.cmbSearchSupplierID.Name = "cmbSearchSupplierID";
            this.cmbSearchSupplierID.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchSupplierID.TabIndex = 8;
            this.cmbSearchSupplierID.SelectedIndexChanged += new System.EventHandler(this.cmbSearchSupplierID_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(333, 286);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Location = new System.Drawing.Point(35, 286);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(91, 31);
            this.btnAddSupplier.TabIndex = 8;
            this.btnAddSupplier.Text = "New Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(183, 23);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(171, 20);
            this.txtSupplierID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(183, 71);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(171, 20);
            this.txtSupplierName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(183, 182);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(183, 123);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(171, 20);
            this.txtContact.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(485, 378);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = global::ShopifyApp.Properties.Resources.finalpicc;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(1, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1255, 76);
            this.panel3.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SearchbyID";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(1, 655);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1255, 35);
            this.panel4.TabIndex = 20;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1256, 691);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Manage";
            this.Text = "Manage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbSearchSupplierID;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnDeleting;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
    }
}