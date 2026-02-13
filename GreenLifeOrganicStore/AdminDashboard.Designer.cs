namespace GreenLifeOrganicStore
{
    partial class AdminDashboard
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
            this.lblActiveOrders = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblProductsInStock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActiveOrders
            // 
            this.lblActiveOrders.AutoSize = true;
            this.lblActiveOrders.Location = new System.Drawing.Point(384, 134);
            this.lblActiveOrders.Name = "lblActiveOrders";
            this.lblActiveOrders.Size = new System.Drawing.Size(88, 16);
            this.lblActiveOrders.TabIndex = 0;
            this.lblActiveOrders.Text = "Active Orders";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(51, 134);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(76, 16);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // lblProductsInStock
            // 
            this.lblProductsInStock.AutoSize = true;
            this.lblProductsInStock.Location = new System.Drawing.Point(187, 134);
            this.lblProductsInStock.Name = "lblProductsInStock";
            this.lblProductsInStock.Size = new System.Drawing.Size(110, 16);
            this.lblProductsInStock.TabIndex = 2;
            this.lblProductsInStock.Text = "Products In Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Admin Dashboard";
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Location = new System.Drawing.Point(31, 222);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(74, 54);
            this.btnManageProducts.TabIndex = 4;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Location = new System.Drawing.Point(152, 222);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(74, 54);
            this.btnManageCustomers.TabIndex = 5;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Location = new System.Drawing.Point(276, 222);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(74, 54);
            this.btnManageOrders.TabIndex = 6;
            this.btnManageOrders.Text = "Manage Orders";
            this.btnManageOrders.UseVisualStyleBackColor = true;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(398, 222);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(74, 54);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 322);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnManageOrders);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProductsInStock);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.lblActiveOrders);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActiveOrders;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblProductsInStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnReports;
    }
}