namespace GUI
{
    partial class UC_SuDungDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.cboKHma = new System.Windows.Forms.ComboBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.pnl_giohang = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_dichvu = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_select = new System.Windows.Forms.Panel();
            this.dvma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nvma = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnl_giohang.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnl_dichvu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Teal;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuu.Location = new System.Drawing.Point(655, 90);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 34);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu\r\n";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "NV mã";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(575, 61);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(141, 20);
            this.txtTongTien.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "KH mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hóa đơn dịch vụ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_nvma);
            this.panel3.Controls.Add(this.btnXemDS);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.cboKHma);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.txtma);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 125);
            this.panel3.TabIndex = 5;
            // 
            // btnXemDS
            // 
            this.btnXemDS.BackColor = System.Drawing.Color.Teal;
            this.btnXemDS.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnXemDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXemDS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemDS.Location = new System.Drawing.Point(527, 90);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(96, 34);
            this.btnXemDS.TabIndex = 30;
            this.btnXemDS.Text = "Xem DS";
            this.btnXemDS.UseVisualStyleBackColor = false;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // cboKHma
            // 
            this.cboKHma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKHma.FormattingEnabled = true;
            this.cboKHma.Location = new System.Drawing.Point(311, 59);
            this.cboKHma.Name = "cboKHma";
            this.cboKHma.Size = new System.Drawing.Size(141, 21);
            this.cboKHma.TabIndex = 27;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(435, 10);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(141, 20);
            this.txtma.TabIndex = 17;
            this.txtma.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã";
            this.label4.Visible = false;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AllowUserToOrderColumns = true;
            this.dgvDichVu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.soluong,
            this.donvitinh,
            this.gia});
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(386, 224);
            this.dgvDichVu.TabIndex = 1;
            this.dgvDichVu.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellEndEdit);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            this.ma.Width = 40;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.Width = 80;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 50;
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn vị";
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Width = 70;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.Width = 90;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvma,
            this.soluongdv,
            this.thanhtien});
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(0, 0);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvGioHang.Size = new System.Drawing.Size(356, 228);
            this.dgvGioHang.TabIndex = 1;
            this.dgvGioHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellEndEdit);
            // 
            // pnl_giohang
            // 
            this.pnl_giohang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnl_giohang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_giohang.Controls.Add(this.panel6);
            this.pnl_giohang.Controls.Add(this.btnXoaAll);
            this.pnl_giohang.Controls.Add(this.btnXoa);
            this.pnl_giohang.Controls.Add(this.label2);
            this.pnl_giohang.Location = new System.Drawing.Point(402, 6);
            this.pnl_giohang.Name = "pnl_giohang";
            this.pnl_giohang.Size = new System.Drawing.Size(357, 283);
            this.pnl_giohang.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvGioHang);
            this.panel6.Location = new System.Drawing.Point(3, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(356, 228);
            this.panel6.TabIndex = 33;
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.BackColor = System.Drawing.Color.Teal;
            this.btnXoaAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnXoaAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaAll.Location = new System.Drawing.Point(220, 16);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(65, 30);
            this.btnXoaAll.TabIndex = 32;
            this.btnXoaAll.Text = "xoá hết";
            this.btnXoaAll.UseVisualStyleBackColor = false;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(302, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(49, 30);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(102, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giỏ hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(80, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách dịch vụ";
            // 
            // pnl_dichvu
            // 
            this.pnl_dichvu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnl_dichvu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_dichvu.Controls.Add(this.panel5);
            this.pnl_dichvu.Controls.Add(this.panel4);
            this.pnl_dichvu.Location = new System.Drawing.Point(3, 0);
            this.pnl_dichvu.Name = "pnl_dichvu";
            this.pnl_dichvu.Size = new System.Drawing.Size(394, 283);
            this.pnl_dichvu.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvDichVu);
            this.panel5.Location = new System.Drawing.Point(3, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(386, 224);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 45);
            this.panel4.TabIndex = 0;
            // 
            // pnl_select
            // 
            this.pnl_select.Controls.Add(this.pnl_dichvu);
            this.pnl_select.Location = new System.Drawing.Point(3, 6);
            this.pnl_select.Name = "pnl_select";
            this.pnl_select.Size = new System.Drawing.Size(756, 286);
            this.pnl_select.TabIndex = 2;
            // 
            // dvma
            // 
            this.dvma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dvma.DataPropertyName = "dichvuma";
            this.dvma.HeaderText = "Tên dịch vụ";
            this.dvma.Name = "dvma";
            this.dvma.ReadOnly = true;
            this.dvma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // soluongdv
            // 
            this.soluongdv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluongdv.DataPropertyName = "soluong";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.soluongdv.DefaultCellStyle = dataGridViewCellStyle3;
            this.soluongdv.HeaderText = "Số lượng";
            this.soluongdv.Name = "soluongdv";
            this.soluongdv.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // txt_nvma
            // 
            this.txt_nvma.Enabled = false;
            this.txt_nvma.Location = new System.Drawing.Point(66, 61);
            this.txt_nvma.Name = "txt_nvma";
            this.txt_nvma.Size = new System.Drawing.Size(141, 20);
            this.txt_nvma.TabIndex = 31;
            // 
            // UC_SuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnl_giohang);
            this.Controls.Add(this.pnl_select);
            this.Controls.Add(this.panel3);
            this.Name = "UC_SuDungDichVu";
            this.Size = new System.Drawing.Size(762, 424);
            this.Load += new System.EventHandler(this.UC_SuDungDichVu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnl_giohang.ResumeLayout(false);
            this.pnl_giohang.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.pnl_dichvu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnl_select.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Panel pnl_giohang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Panel pnl_dichvu;
        private System.Windows.Forms.ComboBox cboKHma;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_select;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvma;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.TextBox txt_nvma;
    }
}
