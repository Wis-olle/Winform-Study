namespace study
{
    partial class FQuanLy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pageHeader1 = new AntdUI.PageHeader();
            pnlHeader = new AntdUI.Panel();
            pnlThemSuaXoa = new AntdUI.Panel();
            btnThoat = new AntdUI.Button();
            btnIn = new AntdUI.Button();
            btnXoa = new AntdUI.Button();
            btnSua = new AntdUI.Button();
            btnThem = new AntdUI.Button();
            ipPhone = new AntdUI.Input();
            ipEmail = new AntdUI.Input();
            ipLocation = new AntdUI.Input();
            lblLocation = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            slGioiTinh = new AntdUI.Select();
            dpNgaySinh = new AntdUI.DatePicker();
            ipTenTG = new AntdUI.Input();
            ipMaTG = new AntdUI.Input();
            lblGioiTinh = new Label();
            lblNgaySinh = new Label();
            lblTenTG = new Label();
            lblMaTG = new Label();
            lbl1 = new Label();
            pnlTimKiem = new AntdUI.Panel();
            ipTimPhone = new AntdUI.Input();
            slTimSex = new AntdUI.Select();
            ipTimTen = new AntdUI.Input();
            ipTimMa = new AntdUI.Input();
            btmTimKiem = new AntdUI.Button();
            lblTimKiemPhone = new Label();
            lblTimKiemSex = new Label();
            lblTimKiemTen = new Label();
            lblTimKiemMa = new Label();
            pnlDanhSach = new AntdUI.Panel();
            tableTacGia = new AntdUI.Table();
            pnlHeader.SuspendLayout();
            pnlThemSuaXoa.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            pnlDanhSach.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader1
            // 
            pageHeader1.BackColor = SystemColors.HotTrack;
            pageHeader1.Dock = DockStyle.Top;
            pageHeader1.ForeColor = Color.White;
            pageHeader1.Location = new Point(0, 0);
            pageHeader1.Name = "pageHeader1";
            pageHeader1.ShowButton = true;
            pageHeader1.Size = new Size(1445, 30);
            pageHeader1.TabIndex = 0;
            pageHeader1.Text = "Quản Lý Tác Giả";
            pageHeader1.UseForeColorDrawIcons = true;
            pageHeader1.UseSystemStyleColor = true;
            // 
            // pnlHeader
            // 
            pnlHeader.BorderColor = Color.Gray;
            pnlHeader.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            pnlHeader.BorderWidth = 0.5F;
            pnlHeader.Controls.Add(pnlThemSuaXoa);
            pnlHeader.Controls.Add(ipPhone);
            pnlHeader.Controls.Add(ipEmail);
            pnlHeader.Controls.Add(ipLocation);
            pnlHeader.Controls.Add(lblLocation);
            pnlHeader.Controls.Add(lblEmail);
            pnlHeader.Controls.Add(lblPhone);
            pnlHeader.Controls.Add(slGioiTinh);
            pnlHeader.Controls.Add(dpNgaySinh);
            pnlHeader.Controls.Add(ipTenTG);
            pnlHeader.Controls.Add(ipMaTG);
            pnlHeader.Controls.Add(lblGioiTinh);
            pnlHeader.Controls.Add(lblNgaySinh);
            pnlHeader.Controls.Add(lblTenTG);
            pnlHeader.Controls.Add(lblMaTG);
            pnlHeader.Controls.Add(lbl1);
            pnlHeader.Location = new Point(21, 58);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Radius = 10;
            pnlHeader.Size = new Size(1398, 359);
            pnlHeader.TabIndex = 1;
            pnlHeader.Text = "panel1";
            // 
            // pnlThemSuaXoa
            // 
            pnlThemSuaXoa.Controls.Add(btnThoat);
            pnlThemSuaXoa.Controls.Add(btnIn);
            pnlThemSuaXoa.Controls.Add(btnXoa);
            pnlThemSuaXoa.Controls.Add(btnSua);
            pnlThemSuaXoa.Controls.Add(btnThem);
            pnlThemSuaXoa.Location = new Point(81, 256);
            pnlThemSuaXoa.Name = "pnlThemSuaXoa";
            pnlThemSuaXoa.Size = new Size(1236, 76);
            pnlThemSuaXoa.TabIndex = 17;
            pnlThemSuaXoa.Text = "panel1";
            pnlThemSuaXoa.Click += pnlTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.DefaultBack = Color.SlateBlue;
            btnThoat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(1027, 20);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(189, 53);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnIn
            // 
            btnIn.DefaultBack = Color.RoyalBlue;
            btnIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnIn.ForeColor = Color.White;
            btnIn.Location = new Point(770, 20);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(189, 53);
            btnIn.TabIndex = 3;
            btnIn.Text = "In";
            btnIn.Click += btnIn_Click;
            // 
            // btnXoa
            // 
            btnXoa.DefaultBack = Color.Maroon;
            btnXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(520, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(189, 53);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.DefaultBack = Color.Chocolate;
            btnSua.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(279, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(189, 53);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.DefaultBack = Color.Green;
            btnThem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(28, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(189, 53);
            btnThem.TabIndex = 0;
            btnThem.Text = "Lưu";
            btnThem.Click += btnThem_Click;
            // 
            // ipPhone
            // 
            ipPhone.BorderColor = Color.Gray;
            ipPhone.ForeColor = Color.Gray;
            ipPhone.Location = new Point(930, 40);
            ipPhone.Name = "ipPhone";
            ipPhone.Size = new Size(387, 46);
            ipPhone.TabIndex = 16;
            ipPhone.Text = "Nhập số điện thoại";
            // 
            // ipEmail
            // 
            ipEmail.BorderColor = Color.Gray;
            ipEmail.ForeColor = Color.Gray;
            ipEmail.Location = new Point(930, 92);
            ipEmail.Name = "ipEmail";
            ipEmail.Size = new Size(387, 46);
            ipEmail.TabIndex = 15;
            ipEmail.Text = "Nhập Email";
            // 
            // ipLocation
            // 
            ipLocation.BorderColor = Color.Gray;
            ipLocation.ForeColor = Color.Gray;
            ipLocation.Location = new Point(930, 144);
            ipLocation.Name = "ipLocation";
            ipLocation.Size = new Size(387, 98);
            ipLocation.TabIndex = 13;
            ipLocation.Text = "Nhập địa chỉ";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(804, 157);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(47, 17);
            lblLocation.TabIndex = 11;
            lblLocation.Text = "Địa chỉ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(804, 102);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 17);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(804, 52);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 17);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Điện thoại";
            // 
            // slGioiTinh
            // 
            slGioiTinh.Location = new Point(187, 196);
            slGioiTinh.Name = "slGioiTinh";
            slGioiTinh.Size = new Size(387, 46);
            slGioiTinh.TabIndex = 8;
            slGioiTinh.Text = "Chọn giới tính";
            // 
            // dpNgaySinh
            // 
            dpNgaySinh.BorderColor = Color.Gray;
            dpNgaySinh.ForeColor = Color.Gray;
            dpNgaySinh.Location = new Point(187, 144);
            dpNgaySinh.Name = "dpNgaySinh";
            dpNgaySinh.Size = new Size(387, 46);
            dpNgaySinh.TabIndex = 7;
            // 
            // ipTenTG
            // 
            ipTenTG.BorderColor = Color.Gray;
            ipTenTG.ForeColor = Color.Gray;
            ipTenTG.Location = new Point(187, 92);
            ipTenTG.Name = "ipTenTG";
            ipTenTG.Size = new Size(387, 46);
            ipTenTG.TabIndex = 6;
            ipTenTG.Text = "Nhập tên tác giả";
            // 
            // ipMaTG
            // 
            ipMaTG.BorderColor = Color.Gray;
            ipMaTG.ForeColor = Color.Gray;
            ipMaTG.Location = new Point(187, 40);
            ipMaTG.Name = "ipMaTG";
            ipMaTG.Size = new Size(387, 46);
            ipMaTG.TabIndex = 5;
            ipMaTG.Text = "Nhập mã tác giả";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(81, 207);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(56, 17);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(81, 157);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(66, 17);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblTenTG
            // 
            lblTenTG.AutoSize = true;
            lblTenTG.Location = new Point(81, 102);
            lblTenTG.Name = "lblTenTG";
            lblTenTG.Size = new Size(64, 17);
            lblTenTG.TabIndex = 2;
            lblTenTG.Text = "Họ và tên";
            // 
            // lblMaTG
            // 
            lblMaTG.AutoSize = true;
            lblMaTG.Location = new Point(81, 52);
            lblMaTG.Name = "lblMaTG";
            lblMaTG.Size = new Size(70, 17);
            lblMaTG.TabIndex = 1;
            lblMaTG.Text = "Mã tác giả";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl1.ForeColor = SystemColors.Highlight;
            lbl1.Location = new Point(13, 10);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(156, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "Thông tin tác giả";
            lbl1.Click += label1_Click;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.BorderColor = Color.Gray;
            pnlTimKiem.BorderWidth = 1F;
            pnlTimKiem.Controls.Add(ipTimPhone);
            pnlTimKiem.Controls.Add(slTimSex);
            pnlTimKiem.Controls.Add(ipTimTen);
            pnlTimKiem.Controls.Add(ipTimMa);
            pnlTimKiem.Controls.Add(btmTimKiem);
            pnlTimKiem.Controls.Add(lblTimKiemPhone);
            pnlTimKiem.Controls.Add(lblTimKiemSex);
            pnlTimKiem.Controls.Add(lblTimKiemTen);
            pnlTimKiem.Controls.Add(lblTimKiemMa);
            pnlTimKiem.Location = new Point(21, 444);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1398, 61);
            pnlTimKiem.TabIndex = 2;
            pnlTimKiem.Text = "panel1";
            // 
            // ipTimPhone
            // 
            ipTimPhone.BorderColor = Color.Gray;
            ipTimPhone.ForeColor = Color.Gray;
            ipTimPhone.Location = new Point(991, 6);
            ipTimPhone.Name = "ipTimPhone";
            ipTimPhone.Size = new Size(201, 46);
            ipTimPhone.TabIndex = 17;
            ipTimPhone.Text = "Nhập số điện thoại";
            // 
            // slTimSex
            // 
            slTimSex.Location = new Point(724, 6);
            slTimSex.Name = "slTimSex";
            slTimSex.Size = new Size(188, 46);
            slTimSex.TabIndex = 14;
            slTimSex.Text = "Chọn giới tính";
            // 
            // ipTimTen
            // 
            ipTimTen.BorderColor = Color.Gray;
            ipTimTen.ForeColor = Color.Gray;
            ipTimTen.Location = new Point(430, 6);
            ipTimTen.Name = "ipTimTen";
            ipTimTen.Size = new Size(226, 46);
            ipTimTen.TabIndex = 13;
            ipTimTen.Text = "Nhập tên tác giả";
            // 
            // ipTimMa
            // 
            ipTimMa.BorderColor = Color.Gray;
            ipTimMa.ForeColor = Color.Gray;
            ipTimMa.Location = new Point(157, 6);
            ipTimMa.Name = "ipTimMa";
            ipTimMa.Size = new Size(197, 46);
            ipTimMa.TabIndex = 12;
            ipTimMa.Text = "Nhập mã tác giả";
            // 
            // btmTimKiem
            // 
            btmTimKiem.DefaultBack = Color.DodgerBlue;
            btmTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btmTimKiem.ForeColor = Color.White;
            btmTimKiem.Location = new Point(1220, 4);
            btmTimKiem.Name = "btmTimKiem";
            btmTimKiem.Size = new Size(97, 48);
            btmTimKiem.TabIndex = 11;
            btmTimKiem.Text = "Tìm Kiếm";
            // 
            // lblTimKiemPhone
            // 
            lblTimKiemPhone.AutoSize = true;
            lblTimKiemPhone.Location = new Point(918, 22);
            lblTimKiemPhone.Name = "lblTimKiemPhone";
            lblTimKiemPhone.Size = new Size(67, 17);
            lblTimKiemPhone.TabIndex = 10;
            lblTimKiemPhone.Text = "Điện thoại";
            // 
            // lblTimKiemSex
            // 
            lblTimKiemSex.AutoSize = true;
            lblTimKiemSex.Location = new Point(662, 22);
            lblTimKiemSex.Name = "lblTimKiemSex";
            lblTimKiemSex.Size = new Size(56, 17);
            lblTimKiemSex.TabIndex = 5;
            lblTimKiemSex.Text = "Giới tính";
            // 
            // lblTimKiemTen
            // 
            lblTimKiemTen.AutoSize = true;
            lblTimKiemTen.Location = new Point(360, 22);
            lblTimKiemTen.Name = "lblTimKiemTen";
            lblTimKiemTen.Size = new Size(64, 17);
            lblTimKiemTen.TabIndex = 3;
            lblTimKiemTen.Text = "Họ và tên";
            // 
            // lblTimKiemMa
            // 
            lblTimKiemMa.AutoSize = true;
            lblTimKiemMa.Location = new Point(81, 22);
            lblTimKiemMa.Name = "lblTimKiemMa";
            lblTimKiemMa.Size = new Size(70, 17);
            lblTimKiemMa.TabIndex = 2;
            lblTimKiemMa.Text = "Mã tác giả";
            // 
            // pnlDanhSach
            // 
            pnlDanhSach.BorderColor = Color.Gray;
            pnlDanhSach.BorderWidth = 1F;
            pnlDanhSach.Controls.Add(tableTacGia);
            pnlDanhSach.Location = new Point(22, 533);
            pnlDanhSach.Name = "pnlDanhSach";
            pnlDanhSach.Size = new Size(1397, 188);
            pnlDanhSach.TabIndex = 3;
            pnlDanhSach.Text = "panel1";
            // 
            // tableTacGia
            // 
            tableTacGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableTacGia.Gap = 12;
            tableTacGia.Location = new Point(12, 4);
            tableTacGia.Name = "tableTacGia";
            tableTacGia.Size = new Size(1371, 180);
            tableTacGia.TabIndex = 0;
            tableTacGia.Text = "table1";
            // 
            // FQuanLy
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1445, 744);
            Controls.Add(pnlDanhSach);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnlHeader);
            Controls.Add(pageHeader1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Name = "FQuanLy";
            Text = "Quan Ly Tac Gia";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlThemSuaXoa.ResumeLayout(false);
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            pnlDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Panel pnlHeader;
        private Label lbl1;
        private Label lblTenTG;
        private Label lblMaTG;
        private Label lblGioiTinh;
        private Label lblNgaySinh;
        private AntdUI.Input ipTenTG;
        private AntdUI.Input ipMaTG;
        private AntdUI.DatePicker dpNgaySinh;
        private AntdUI.Select slGioiTinh;
        private Label lblLocation;
        private Label lblEmail;
        private Label lblPhone;
        private AntdUI.Input ipEmail;
        private AntdUI.Input ipLocation;
        private AntdUI.Input ipPhone;
        private AntdUI.Panel pnlThemSuaXoa;
        private AntdUI.Button btnThem;
        private AntdUI.Button btnSua;
        private AntdUI.Button btnThoat;
        private AntdUI.Button btnIn;
        private AntdUI.Button btnXoa;
        private AntdUI.Panel pnlTimKiem;
        private AntdUI.Button btmTimKiem;
        private Label lblTimKiemPhone;
        private Label lblTimKiemSex;
        private Label lblTimKiemTen;
        private Label lblTimKiemMa;
        private AntdUI.Select slTimSex;
        private AntdUI.Input ipTimTen;
        private AntdUI.Input ipTimMa;
        private AntdUI.Input ipTimPhone;
        private AntdUI.Panel pnlDanhSach;
        private AntdUI.Table tableTacGia;
    }
}
