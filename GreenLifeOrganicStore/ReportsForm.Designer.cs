namespace GreenLifeOrganicStore
{
    partial class ReportsForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(382, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 16);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(36, 117);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(384, 151);
            this.dgvReport.TabIndex = 11;
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(267, 286);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(93, 56);
            this.btnExportPDF.TabIndex = 9;
            this.btnExportPDF.Text = "Export PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(168, 286);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(93, 56);
            this.btnExportCSV.TabIndex = 8;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(68, 286);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(93, 56);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sales",
            "Stock",
            "Order History"});
            this.comboBox1.Location = new System.Drawing.Point(299, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select report type";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnGenerate);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}