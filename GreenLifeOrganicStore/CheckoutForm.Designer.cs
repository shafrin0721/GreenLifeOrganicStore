namespace GreenLifeOrganicStore
{
    partial class CheckoutForm
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
            this.dgvCheckout = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckout
            // 
            this.dgvCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckout.Location = new System.Drawing.Point(40, 379);
            this.dgvCheckout.Name = "dgvCheckout";
            this.dgvCheckout.RowHeadersWidth = 51;
            this.dgvCheckout.RowTemplate.Height = 24;
            this.dgvCheckout.Size = new System.Drawing.Size(330, 177);
            this.dgvCheckout.TabIndex = 0;
            this.dgvCheckout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckout_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Checkout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(68, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 16);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Grand total";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(71, 122);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(130, 20);
            this.rbCash.TabIndex = 4;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash on Delivery";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(227, 122);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(113, 20);
            this.rbCard.TabIndex = 5;
            this.rbCard.TabStop = true;
            this.rbCard.Text = "Card Payment";
            this.rbCard.UseVisualStyleBackColor = true;
            this.rbCard.CheckedChanged += new System.EventHandler(this.rbCard_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Card number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CVV";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "MM/YY expiry";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(67, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(224, 580);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Place order";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtExpiry
            // 
            this.txtExpiry.Location = new System.Drawing.Point(199, 246);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(100, 22);
            this.txtExpiry.TabIndex = 11;
            this.txtExpiry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(199, 206);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(100, 22);
            this.txtCVV.TabIndex = 12;
            this.txtCVV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(199, 166);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(100, 22);
            this.txtCardNumber.TabIndex = 13;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(199, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 14;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(199, 291);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 16;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 635);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtExpiry);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCheckout);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
    }
}