namespace study
{
    public partial class FQuanLy : AntdUI.Window
    {
        public FQuanLy()
        {
            InitializeComponent();

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


