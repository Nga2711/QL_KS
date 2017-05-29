namespace GUI
{
    partial class UC_nhanvien
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTimKiem.Location = new System.Drawing.Point(543, 181);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 20);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.Text = "nhập vào khóa muốn tìm kiếm...";
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTìmKiem_TextChanged);
            this.txtTimKiem.MouseLeave += new System.EventHandler(this.txtTimKiem_MouseLeave);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(137, 98);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(155, 20);
            this.dtpNgaySinh.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtpNgaySinh);
            this.panel3.Controls.Add(this.cboGioiTinh);
            this.panel3.Controls.Add(this.btnCapNhap);
            this.panel3.Controls.Add(this.txtMatKhau);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtTen);
            this.panel3.Controls.Add(this.txtMa);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 128);
            this.panel3.TabIndex = 7;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(137, 69);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(155, 21);
            this.cboGioiTinh.TabIndex = 16;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.BackColor = System.Drawing.Color.Teal;
            this.btnCapNhap.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCapNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCapNhap.Location = new System.Drawing.Point(515, 95);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(75, 30);
            this.btnCapNhap.TabIndex = 14;
            this.btnCapNhap.Text = "Cập nhật";
            this.btnCapNhap.UseVisualStyleBackColor = false;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(476, 69);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(160, 20);
            this.txtMatKhau.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(390, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mật khẩu";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(476, 43);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(160, 20);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(476, 14);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(160, 20);
            this.txtSDT.TabIndex = 10;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(390, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(390, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(57, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(57, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(137, 43);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(155, 20);
            this.txtTen.TabIndex = 3;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(137, 14);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(155, 20);
            this.txtMa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(57, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(57, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.gioitinh,
            this.ngaysinh,
            this.sdt,
            this.diachi,
            this.matkhau});
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.Size = new System.Drawing.Size(762, 217);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            this.ma.HeaderText = "Mã ";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên nhân viên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 130;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 50;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 120;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Width = 127;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.Name = "matkhau";
            this.matkhau.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(690, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhân viên";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(207, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Teal;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Location = new System.Drawing.Point(106, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(3, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnThem_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvNhanVien);
            this.panel2.Location = new System.Drawing.Point(1, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 217);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 41);
            this.panel1.TabIndex = 5;
            // 
            // UC_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_nhanvien";
            this.Size = new System.Drawing.Size(762, 424);
            this.Load += new System.EventHandler(this.UC_nhanvien_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
    }
}
