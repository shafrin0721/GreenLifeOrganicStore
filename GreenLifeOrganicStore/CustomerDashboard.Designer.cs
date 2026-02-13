namespace GreenLifeOrganicStore
{
    partial class CustomerDashboard
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.greenLifeDBDataSet = new GreenLifeOrganicStore.GreenLifeDBDataSet();
            this.greenLifeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLifeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLifeDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(56, 415);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(288, 415);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(378, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(148, 415);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(118, 23);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Add To Cart";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(48, 148);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(406, 224);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // greenLifeDBDataSet
            // 
            this.greenLifeDBDataSet.DataSetName = "GreenLifeDBDataSet";
            this.greenLifeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // greenLifeDBDataSetBindingSource
            // 
            this.greenLifeDBDataSetBindingSource.DataSource = this.greenLifeDBDataSet;
            this.greenLifeDBDataSetBindingSource.Position = 0;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(132, 108);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 22);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(132, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(194, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(125, 16);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome Customer";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(47, 110);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(72, 16);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Total Price";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 468);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnSearch);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLifeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLifeDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource greenLifeDBDataSetBindingSource;
        private GreenLifeDBDataSet greenLifeDBDataSet;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}