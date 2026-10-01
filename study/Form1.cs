namespace study
{
    public partial class FQuanLy : AntdUI.Window
    {
        private readonly Panel contentHost = new() { AutoScroll = true, BackColor = Color.White };
        private bool isLayingOut;

        public FQuanLy()
        {
            InitializeComponent();

            // Keep the designer controls, but place them according to the available
            // client area instead of the resolution used while designing the form.
            Controls.Add(contentHost);
            contentHost.Controls.AddRange([pnlHeader, pnlTimKiem, pnlDanhSach]);
            pageHeader1.BringToFront();
            contentHost.Resize += (_, _) => LayoutContent();
            Resize += (_, _) => UpdateHostBounds();
            Shown += (_, _) => UpdateHostBounds();
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            UpdateHostBounds();

            slGioiTinh.Items.Add("Nam");
            slGioiTinh.Items.Add("Nữ");
            slGioiTinh.Items.Add("Khác");

            slGioiTinh.SelectedIndex = 0;

            tableTacGia.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column("STT", "STT") { Width = "4%" },
                new AntdUI.Column("MaTacGia", "Mã tác giả") { Width = "8%" },
                new AntdUI.Column("HoTen", "Họ và tên") { Width = "13%" },
                new AntdUI.Column("NgaySinh", "Ngày sinh") { Width = "10%" },
                new AntdUI.Column("GioiTinh", "Giới tính") { Width = "7%" },
                new AntdUI.Column("DienThoai", "Điện thoại") { Width = "11%" },
                new AntdUI.Column("Email", "Email") { Width = "19%" },
                new AntdUI.Column("DiaChi", "Địa chỉ") { Width = "fill" }
            };
            tableTacGia.EmptyHeader = true;
            tableTacGia.EmptyText = "chua co du lieu";
        }

        private int Px(int value) => (int)Math.Round(value * DeviceDpi / 96f);

        private void UpdateHostBounds()
        {
            int top = pageHeader1.Bottom;
            contentHost.Bounds = new Rectangle(0, top, ClientSize.Width, Math.Max(0, ClientSize.Height - top));
            LayoutContent();
        }

        private void LayoutContent()
        {
            if (isLayingOut || contentHost.ClientSize.Width <= 0) return;
            isLayingOut = true;

            contentHost.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlTimKiem.SuspendLayout();

            int margin = Px(16);
            int gap = Px(12);
            int width = Math.Max(Px(360), contentHost.ClientSize.Width - 2 * margin - SystemInformation.VerticalScrollBarWidth);
            bool twoColumns = width >= Px(850);
            int fieldTop = Px(44);
            int rowHeight = Px(50);
            int labelWidth = Px(90);
            int fieldGap = Px(8);
            int columnGap = Px(24);
            int innerWidth = width - 2 * margin;
            int columnWidth = twoColumns ? (innerWidth - columnGap) / 2 : innerWidth;

            lbl1.Location = new Point(margin, Px(10));
            PlaceField(lblMaTG, ipMaTG, margin, fieldTop, columnWidth, labelWidth, fieldGap);
            PlaceField(lblTenTG, ipTenTG, margin, fieldTop + rowHeight, columnWidth, labelWidth, fieldGap);
            PlaceField(lblNgaySinh, dpNgaySinh, margin, fieldTop + 2 * rowHeight, columnWidth, labelWidth, fieldGap);
            PlaceField(lblGioiTinh, slGioiTinh, margin, fieldTop + 3 * rowHeight, columnWidth, labelWidth, fieldGap);

            int rightX = twoColumns ? margin + columnWidth + columnGap : margin;
            int rightTop = twoColumns ? fieldTop : fieldTop + 4 * rowHeight;
            PlaceField(lblPhone, ipPhone, rightX, rightTop, columnWidth, labelWidth, fieldGap);
            PlaceField(lblEmail, ipEmail, rightX, rightTop + rowHeight, columnWidth, labelWidth, fieldGap);
            PlaceField(lblLocation, ipLocation, rightX, rightTop + 2 * rowHeight, columnWidth, labelWidth, fieldGap);
            ipLocation.Height = twoColumns ? 2 * rowHeight - Px(4) : Px(44);

            int buttonTop = fieldTop + (twoColumns ? 4 : 7) * rowHeight + Px(8);
            int buttonsPerRow = width >= Px(650) ? 5 : 3;
            int buttonHeight = Px(46);
            var buttons = new[] { btnThem, btnSua, btnXoa, btnIn, btnThoat };
            int buttonRows = (buttons.Length + buttonsPerRow - 1) / buttonsPerRow;
            pnlThemSuaXoa.Bounds = new Rectangle(margin, buttonTop, innerWidth, buttonRows * buttonHeight + (buttonRows - 1) * gap);
            for (int i = 0; i < buttons.Length; i++)
            {
                int row = i / buttonsPerRow;
                int count = Math.Min(buttonsPerRow, buttons.Length - row * buttonsPerRow);
                int buttonWidth = (innerWidth - (count - 1) * gap) / count;
                buttons[i].Bounds = new Rectangle((i % buttonsPerRow) * (buttonWidth + gap), row * (buttonHeight + gap), buttonWidth, buttonHeight);
            }

            int headerHeight = buttonTop + pnlThemSuaXoa.Height + Px(16);
            pnlHeader.Bounds = new Rectangle(margin, Px(14), width, headerHeight);

            int searchColumns = width >= Px(1000) ? 4 : width >= Px(650) ? 2 : 1;
            int searchRowHeight = Px(48);
            int searchGap = Px(8);
            int searchRows = (4 + searchColumns - 1) / searchColumns;
            int searchButtonWidth = Px(88);
            int searchCellWidth = searchColumns == 4
                ? (innerWidth - searchButtonWidth - 4 * searchGap) / 4
                : (innerWidth - (searchColumns - 1) * searchGap) / searchColumns;
            Label[] searchLabels = [lblTimKiemMa, lblTimKiemTen, lblTimKiemSex, lblTimKiemPhone];
            Control[] searchInputs = [ipTimMa, ipTimTen, slTimSex, ipTimPhone];
            for (int i = 0; i < searchInputs.Length; i++)
            {
                int x = margin + (i % searchColumns) * (searchCellWidth + searchGap);
                int y = Px(8) + (i / searchColumns) * searchRowHeight;
                int searchLabelWidth = searchColumns == 4 ? Px(72) : labelWidth;
                PlaceField(searchLabels[i], searchInputs[i], x, y, searchCellWidth, searchLabelWidth, Px(4));
            }

            int searchHeight;
            if (searchColumns == 4)
            {
                btmTimKiem.Bounds = new Rectangle(margin + 4 * (searchCellWidth + searchGap), Px(8), searchButtonWidth, Px(42));
                searchHeight = Px(58);
            }
            else
            {
                btmTimKiem.Bounds = new Rectangle(margin, Px(8) + searchRows * searchRowHeight, innerWidth, Px(42));
                searchHeight = Px(8) + searchRows * searchRowHeight + Px(50);
            }

            int searchY = pnlHeader.Bottom + gap;
            pnlTimKiem.Bounds = new Rectangle(margin, searchY, width, searchHeight);

            int tableY = pnlTimKiem.Bottom + gap;
            int availableHeight = contentHost.ClientSize.Height - tableY - margin;
            int tableHeight = Math.Max(Px(150), availableHeight);
            pnlDanhSach.Bounds = new Rectangle(margin, tableY, width, tableHeight);
            tableTacGia.Bounds = new Rectangle(Px(10), Px(6), width - Px(20), tableHeight - Px(12));
            pnlTimKiem.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            contentHost.ResumeLayout(true);
            contentHost.AutoScroll = false;
            contentHost.AutoScroll = true;
            contentHost.AutoScrollMinSize = new Size(0, pnlDanhSach.Bottom + margin);
            isLayingOut = false;
        }

        private void PlaceField(Label label, Control input, int x, int y, int width, int labelWidth, int gap)
        {
            int fieldHeight = Px(44);
            label.Location = new Point(x, y + (fieldHeight - label.Height) / 2);
            input.Bounds = new Rectangle(x + labelWidth + gap, y, Math.Max(Px(90), width - labelWidth - gap), fieldHeight);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}


