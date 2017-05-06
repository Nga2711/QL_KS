namespace GUI
{
    partial class frmCTHDdichvu
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
            this.dgvCTHDdichvu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHDDVma = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDdichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết hoá đơn dịch vụ";
            // 
            // dgvCTHDdichvu
            // 
            this.dgvCTHDdichvu.AllowUserToAddRows = false;
            this.dgvCTHDdichvu.AllowUserToDeleteRows = false;
            this.dgvCTHDdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDdichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCTHDdichvu.Location = new System.Drawing.Point(2, 99);
            this.dgvCTHDdichvu.Name = "dgvCTHDdichvu";
            this.dgvCTHDdichvu.ReadOnly = true;
            this.dgvCTHDdichvu.Size = new System.Drawing.Size(475, 185);
            this.dgvCTHDdichvu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hoá đơn DV";
            // 
            // cboHDDVma
            // 
            this.cboHDDVma.FormattingEnabled = true;
            this.cboHDDVma.Location = new System.Drawing.Point(127, 48);
            this.cboHDDVma.Name = "cboHDDVma";
            this.cboHDDVma.Size = new System.Drawing.Size(152, 21);
            this.cboHDDVma.TabIndex = 3;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(342, 46);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem chi tiết";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "dichvuma";
            this.Column1.HeaderText = "Mã dịch vụ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "soluong";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "thanhtien";
            this.Column3.HeaderText = "Thành tiền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmCTHDdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 286);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cboHDDVma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCTHDdichvu);
            this.Controls.Add(this.label1);
            this.Name = "frmCTHDdichvu";
            this.Text = "Chi tiết hoá đơn dịch vụ";
            this.Load += new System.EventHandler(this.frmCTHDdichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDdichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCTHDdichvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHDDVma;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}