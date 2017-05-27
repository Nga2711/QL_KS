namespace GUI
{
    partial class FormMain
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbDanhMuc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoaiPhong = new System.Windows.Forms.Button();
            this.ntnNhanVien = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.txtSuDung = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lbBaoCao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnND = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thiên Nga";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseDown);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(903, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 43);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbDanhMuc
            // 
            this.lbDanhMuc.AutoSize = true;
            this.lbDanhMuc.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbDanhMuc.Location = new System.Drawing.Point(4, 127);
            this.lbDanhMuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDanhMuc.Name = "lbDanhMuc";
            this.lbDanhMuc.Size = new System.Drawing.Size(78, 15);
            this.lbDanhMuc.TabIndex = 0;
            this.lbDanhMuc.Text = " ▼  Cập nhật";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 43);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolBar_MouseDown);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(818, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(88, 43);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.Silver;
            this.btnDoanhThu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDoanhThu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDoanhThu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Location = new System.Drawing.Point(18, 309);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(191, 30);
            this.btnDoanhThu.TabIndex = 18;
            this.btnDoanhThu.Text = "Doanh thu";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 12;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.Silver;
            this.btnDatPhong.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDatPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDatPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDatPhong.Location = new System.Drawing.Point(13, 22);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(191, 30);
            this.btnDatPhong.TabIndex = 13;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "▼ Quản lý";
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.BackColor = System.Drawing.Color.Silver;
            this.btnLoaiPhong.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoaiPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnLoaiPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiPhong.Location = new System.Drawing.Point(12, 146);
            this.btnLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.Size = new System.Drawing.Size(191, 30);
            this.btnLoaiPhong.TabIndex = 3;
            this.btnLoaiPhong.Text = "Loại phòng";
            this.btnLoaiPhong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLoaiPhong.UseVisualStyleBackColor = false;
            this.btnLoaiPhong.Click += new System.EventHandler(this.btnLoaiPhong_Click);
            // 
            // ntnNhanVien
            // 
            this.ntnNhanVien.BackColor = System.Drawing.Color.Silver;
            this.ntnNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ntnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.ntnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ntnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ntnNhanVien.Location = new System.Drawing.Point(13, 256);
            this.ntnNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.ntnNhanVien.Name = "ntnNhanVien";
            this.ntnNhanVien.Size = new System.Drawing.Size(191, 30);
            this.ntnNhanVien.TabIndex = 6;
            this.ntnNhanVien.Text = "Nhân viên";
            this.ntnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ntnNhanVien.UseVisualStyleBackColor = false;
            this.ntnNhanVien.Click += new System.EventHandler(this.ntnNhanVien_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.Silver;
            this.btnDichVu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDichVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDichVu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Location = new System.Drawing.Point(13, 220);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(191, 30);
            this.btnDichVu.TabIndex = 5;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // txtSuDung
            // 
            this.txtSuDung.BackColor = System.Drawing.Color.Silver;
            this.txtSuDung.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.txtSuDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.txtSuDung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.txtSuDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtSuDung.Location = new System.Drawing.Point(13, 58);
            this.txtSuDung.Name = "txtSuDung";
            this.txtSuDung.Size = new System.Drawing.Size(191, 30);
            this.txtSuDung.TabIndex = 13;
            this.txtSuDung.Text = "Sử dụng dịch vụ";
            this.txtSuDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSuDung.UseVisualStyleBackColor = false;
            this.txtSuDung.Click += new System.EventHandler(this.txtSuDung_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.Color.Silver;
            this.btnPhong.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Location = new System.Drawing.Point(12, 184);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(191, 33);
            this.btnPhong.TabIndex = 4;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Silver;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Location = new System.Drawing.Point(12, 94);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(191, 30);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lbBaoCao
            // 
            this.lbBaoCao.AutoSize = true;
            this.lbBaoCao.ForeColor = System.Drawing.Color.Navy;
            this.lbBaoCao.Location = new System.Drawing.Point(9, 290);
            this.lbBaoCao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBaoCao.Name = "lbBaoCao";
            this.lbBaoCao.Size = new System.Drawing.Size(71, 15);
            this.lbBaoCao.TabIndex = 16;
            this.lbBaoCao.Text = "▼  Báo cáo";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDoanhThu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDatPhong);
            this.panel2.Controls.Add(this.lbDanhMuc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLoaiPhong);
            this.panel2.Controls.Add(this.ntnNhanVien);
            this.panel2.Controls.Add(this.btnDichVu);
            this.panel2.Controls.Add(this.txtSuDung);
            this.panel2.Controls.Add(this.btnPhong);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.lbBaoCao);
            this.panel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 437);
            this.panel2.TabIndex = 7;
            // 
            // pnND
            // 
            this.pnND.Location = new System.Drawing.Point(223, 50);
            this.pnND.Name = "pnND";
            this.pnND.Size = new System.Drawing.Size(762, 421);
            this.pnND.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(990, 480);
            this.Controls.Add(this.pnND);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbDanhMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoaiPhong;
        private System.Windows.Forms.Button ntnNhanVien;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button txtSuDung;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lbBaoCao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnND;
    }
}