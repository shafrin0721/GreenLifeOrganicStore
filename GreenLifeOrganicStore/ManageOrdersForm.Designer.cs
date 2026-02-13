namespace GreenLifeOrganicStore
{
    partial class ManageOrdersForm
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
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnViewItems = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(116, 289);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(119, 37);
            this.btnUpdateStatus.TabIndex = 0;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnViewItems
            // 
            this.btnViewItems.Location = new System.Drawing.Point(245, 289);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(119, 37);
            this.btnViewItems.TabIndex = 1;
            this.btnViewItems.Text = "View Items";
            this.btnViewItems.UseVisualStyleBackColor = true;
            this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pending",
            "Shipped",
            "Delivered"});
            this.comboBox1.Location = new System.Drawing.Point(130, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(35, 126);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(455, 140);
            this.dgvOrders.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "status update";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(442, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 16);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ManageOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 350);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnViewItems);
            this.Controls.Add(this.btnUpdateStatus);
            this.Name = "ManageOrdersForm";
            this.Text = "ManageOrdersForm";
            this.Load += new System.EventHandler(this.ManageOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}