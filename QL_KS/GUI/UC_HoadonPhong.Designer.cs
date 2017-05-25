namespace GUI
{
    partial class UC_HoadonPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSongay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhongma = new System.Windows.Forms.TextBox();
            this.cboNVma = new System.Windows.Forms.ComboBox();
            this.cboPTma = new System.Windows.Forms.ComboBox();
            this.dtpngaydi = new System.Windows.Forms.DateTimePicker();
            this.dtpngaytt = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.ptma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(557, 89);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(112, 20);
            this.txtThanhTien.TabIndex = 17;
            // 
            // txtSongay
            // 
            this.txtSongay.Location = new System.Drawing.Point(557, 55);
            this.txtSongay.Name = "txtSongay";
            this.txtSongay.Size = new System.Drawing.Size(112, 20);
            this.txtSongay.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(483, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Thành tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(18, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "NV lập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtPhongma);
            this.panel1.Controls.Add(this.cboNVma);
            this.panel1.Controls.Add(this.cboPTma);
            this.panel1.Controls.Add(this.dtpngaydi);
            this.panel1.Controls.Add(this.dtpngaytt);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.txtSongay);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 130);
            this.panel1.TabIndex = 27;
            // 
            // txtPhongma
            // 
            this.txtPhongma.Location = new System.Drawing.Point(557, 19);
            this.txtPhongma.Name = "txtPhongma";
            this.txtPhongma.Size = new System.Drawing.Size(112, 20);
            this.txtPhongma.TabIndex = 35;
            // 
            // cboNVma
            // 
            this.cboNVma.FormattingEnabled = true;
            this.cboNVma.Location = new System.Drawing.Point(85, 55);
            this.cboNVma.Name = "cboNVma";
            this.cboNVma.Size = new System.Drawing.Size(112, 21);
            this.cboNVma.TabIndex = 34;
            // 
            // cboPTma
            // 
            this.cboPTma.FormattingEnabled = true;
            this.cboPTma.Location = new System.Drawing.Point(85, 17);
            this.cboPTma.Name = "cboPTma";
            this.cboPTma.Size = new System.Drawing.Size(112, 21);
            this.cboPTma.TabIndex = 31;
            this.cboPTma.SelectedIndexChanged += new System.EventHandler(this.cboPTma_SelectedIndexChanged);
            // 
            // dtpngaydi
            // 
            this.dtpngaydi.Location = new System.Drawing.Point(315, 56);
            this.dtpngaydi.Name = "dtpngaydi";
            this.dtpngaydi.Size = new System.Drawing.Size(139, 20);
            this.dtpngaydi.TabIndex = 21;
            this.dtpngaydi.ValueChanged += new System.EventHandler(this.dtpngaydi_ValueChanged);
            // 
            // dtpngaytt
            // 
            this.dtpngaytt.Location = new System.Drawing.Point(315, 19);
            this.dtpngaytt.Name = "dtpngaytt";
            this.dtpngaytt.Size = new System.Drawing.Size(139, 20);
            this.dtpngaytt.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(483, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Số ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(208, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày đi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(208, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(483, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã PT";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInHoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInHoaDon.Location = new System.Drawing.Point(632, 383);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(96, 33);
            this.btnInHoaDon.TabIndex = 29;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Location = new System.Drawing.Point(479, 383);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 33);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = " Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.AllowUserToAddRows = false;
            this.dgvhoadon.AllowUserToDeleteRows = false;
            this.dgvhoadon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ptma,
            this.pma,
            this.ngaythanhtoan,
            this.ngaydi,
            this.songay,
            this.NVma,
            this.thanhtien});
            this.dgvhoadon.Location = new System.Drawing.Point(3, 180);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.ReadOnly = true;
            this.dgvhoadon.Size = new System.Drawing.Size(756, 197);
            this.dgvhoadon.TabIndex = 26;
            // 
            // ptma
            // 
            this.ptma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ptma.DataPropertyName = "phieuthuema";
            this.ptma.HeaderText = "Mã PT";
            this.ptma.Name = "ptma";
            this.ptma.ReadOnly = true;
            // 
            // pma
            // 
            this.pma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pma.DataPropertyName = "phongma";
            this.pma.HeaderText = "Mã P";
            this.pma.Name = "pma";
            this.pma.ReadOnly = true;
            // 
            // ngaythanhtoan
            // 
            this.ngaythanhtoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaythanhtoan.DataPropertyName = "ngaythanhtoan";
            this.ngaythanhtoan.HeaderText = "Ngày thanh toán";
            this.ngaythanhtoan.Name = "ngaythanhtoan";
            this.ngaythanhtoan.ReadOnly = true;
            // 
            // ngaydi
            // 
            this.ngaydi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaydi.DataPropertyName = "ngaydi";
            this.ngaydi.HeaderText = "Ngày đi";
            this.ngaydi.Name = "ngaydi";
            this.ngaydi.ReadOnly = true;
            // 
            // songay
            // 
            this.songay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.songay.DataPropertyName = "songaythue";
            this.songay.HeaderText = "Số ngày";
            this.songay.Name = "songay";
            this.songay.ReadOnly = true;
            // 
            // NVma
            // 
            this.NVma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NVma.DataPropertyName = "nhanvienxacnhan";
            this.NVma.HeaderText = "Nhân viên xác nhận";
            this.NVma.Name = "NVma";
            this.NVma.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(248, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hóa đơn thanh toán tiền phòng";
            // 
            // UC_HoadonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvhoadon);
            this.Controls.Add(this.label1);
            this.Name = "UC_HoadonPhong";
            this.Size = new System.Drawing.Size(762, 424);
            this.Load += new System.EventHandler(this.UC_HoadonPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSongay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpngaydi;
        private System.Windows.Forms.DateTimePicker dtpngaytt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNVma;
        private System.Windows.Forms.ComboBox cboPTma;
        private System.Windows.Forms.TextBox txtPhongma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptma;
        private System.Windows.Forms.DataGridViewTextBoxColumn pma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydi;
        private System.Windows.Forms.DataGridViewTextBoxColumn songay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVma;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}
