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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.cboNVma = new System.Windows.Forms.ComboBox();
            this.cboKHma = new System.Windows.Forms.ComboBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.dvma = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.soluongdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(136, 158);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 34);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXem.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Location = new System.Drawing.Point(262, 158);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(96, 34);
            this.btnXem.TabIndex = 25;
            this.btnXem.Text = "In hóa đơn";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "NV mã";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(280, 90);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 19;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(72, 56);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "KH mã";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(90, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hóa đơn dịch vụ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtpNgay);
            this.panel3.Controls.Add(this.cboNVma);
            this.panel3.Controls.Add(this.cboKHma);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnXem);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.txtma);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(368, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 202);
            this.panel3.TabIndex = 5;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(72, 128);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(147, 20);
            this.dtpNgay.TabIndex = 29;
            // 
            // cboNVma
            // 
            this.cboNVma.FormattingEnabled = true;
            this.cboNVma.Location = new System.Drawing.Point(280, 51);
            this.cboNVma.Name = "cboNVma";
            this.cboNVma.Size = new System.Drawing.Size(100, 21);
            this.cboNVma.TabIndex = 28;
            // 
            // cboKHma
            // 
            this.cboKHma.FormattingEnabled = true;
            this.cboKHma.Location = new System.Drawing.Point(72, 90);
            this.cboKHma.Name = "cboKHma";
            this.cboKHma.Size = new System.Drawing.Size(100, 21);
            this.cboKHma.TabIndex = 27;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvma,
            this.soluongdv,
            this.thanhtien});
            this.dgvGioHang.Location = new System.Drawing.Point(-1, 51);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.Size = new System.Drawing.Size(389, 160);
            this.dgvGioHang.TabIndex = 1;
            this.dgvGioHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellEndEdit);
            this.dgvGioHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellValueChanged);
            this.dgvGioHang.SelectionChanged += new System.EventHandler(this.dgvGioHang_SelectionChanged);
            // 
            // dvma
            // 
            this.dvma.DataPropertyName = "dichvuma";
            this.dvma.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dvma.HeaderText = "Mã dịch vụ";
            this.dvma.Name = "dvma";
            this.dvma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dvma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dvma.Width = 130;
            // 
            // soluongdv
            // 
            this.soluongdv.DataPropertyName = "soluong";
            this.soluongdv.HeaderText = "Số lượng";
            this.soluongdv.Name = "soluongdv";
            this.soluongdv.Width = 130;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            this.thanhtien.Width = 130;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvGioHang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(368, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 212);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(151, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giỏ hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(87, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách dịch vụ";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.soluong,
            this.donvitinh,
            this.gia});
            this.dgvDichVu.Location = new System.Drawing.Point(-1, 51);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.Size = new System.Drawing.Size(364, 368);
            this.dgvDichVu.TabIndex = 1;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "ma";
            this.ma.HeaderText = "Mã";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            this.ma.Width = 40;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            this.ten.Width = 80;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 50;
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn vị";
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.ReadOnly = true;
            this.donvitinh.Width = 70;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.Width = 90;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvDichVu);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 420);
            this.panel1.TabIndex = 3;
            // 
            // UC_SuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_SuDungDichVu";
            this.Size = new System.Drawing.Size(762, 424);
            this.Load += new System.EventHandler(this.UC_SuDungDichVu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.ComboBox cboKHma;
        private System.Windows.Forms.ComboBox cboNVma;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.DataGridViewComboBoxColumn dvma;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}
