namespace GreenLifeOrganicStore
{
    partial class CartForm
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
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(57, 117);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(494, 167);
            this.dgvCart.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(57, 318);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(362, 318);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(231, 60);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(75, 16);
            this.lblGrandTotal.TabIndex = 3;
            this.lblGrandTotal.Text = "GrandTotal";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 376);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvCart);
            this.Name = "CartForm";
            this.Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}