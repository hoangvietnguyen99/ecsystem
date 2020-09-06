using ECSystem.BUS;
using ECSystem.DTO;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECSystem.GUI
{
    public partial class fChiTietDNH : fMaterialSkin
    {
        private MatHangDTO matHang;

        private DonNhapHangDTO donNhapHang;

        private string maNV;

        public fChiTietDNH(DonNhapHangDTO donNhapHang, string maNV)
        {
            InitializeComponent();

            DonNhapHang = donNhapHang;

            MaNV = maNV;

            buttonThemMHMoi.Visible = true;

            LoadFormDetail();

            buttonThemLH.Visible = true;
        }

        public fChiTietDNH(DonNhapHangDTO donNhapHang, MatHangDTO matHang, string maNV)
        {
            InitializeComponent();

            MatHang = matHang;

            MaNV = maNV;

            DonNhapHang = donNhapHang;

            textBoxSLTon.Visible = true;

            LoadFormDetail();

            tbMaMH.ReadOnly = true;

            tbTenMH.ReadOnly = true;

            textBoxSLTon.ReadOnly = true;
        }

        public MatHangDTO MatHang { get => matHang; set => matHang = value; }
        public DonNhapHangDTO DonNhapHang { get => donNhapHang; set => donNhapHang = value; }
        public string MaNV { get => maNV; set => maNV = value; }

        private void LoadFormDetail()
        {
            textBoxMaDNH.Text = DonNhapHang.MaDNH;

            textBoxTongTien.Text = DonNhapHang.TongTien.ToString();

            LoadDTGVCT_DNH();

            if (MatHang != null)
            {
                tbMaMH.Text = MatHang.MaMH;
                tbTenMH.Text = MatHang.TenMH;
                LoaiHangDTO loaiHang = MatHangBUS.Instance.LayLoaiHang(MatHang.MaMH);
                comboBoxLoaiHang.DataSource = new List<string>() { loaiHang.MaLH + loaiHang.TenLH };
                textBoxSLTon.Text = MatHang.SLTon.ToString();
                numericUpDownDonGia.Value = Int32.Parse(MatHang.GiaTien.ToString());
            }
            else
            {
                LoadComboBoxLH();
            }
        }

        private void LoadDTGVCT_DNH()
        {
            dtgvDSCT_DDH.DataSource = DonNhapHangBUS.Instance.DSCT_DNH(textBoxMaDNH.Text);
        }

        private void LoadComboBoxLH()
        {
            comboBoxLoaiHang.DataSource = LoaiHangBUS.Instance.LayDSTenLoaiHang();
        }

        private void buttonThemLH_Click(object sender, EventArgs e)
        {
            fThemLoaiHang f = new fThemLoaiHang(MaNV);

            f.ShowDialog();

            LoadComboBoxLH();
        }

        private void buttonThemMHMoi_Click(object sender, EventArgs e)
        {
            if (tbMaMH.TextLength == 0 || tbTenMH.TextLength == 0 || comboBoxLoaiHang.Text.Length == 0 || numericUpDownSLThem.Value == 0)
            {
                MaterialMessageBox.Show("Vui lòng nhập đầy đủ các trường.", "Cảnh báo");
                return;
            }

            int result = MatHangBUS.Instance.ThemMatHang(tbMaMH.Text, tbTenMH.Text, (double)numericUpDownDonGia.Value, 0, comboBoxLoaiHang.Text);

            if (result != 1)
            {
                MaterialMessageBox.Show("Thêm mặt hàng thất bại.", "Thất bại");
                return;
            }

            MaterialMessageBox.Show("Thêm mặt hàng thành công.", "Thành công");
        }

        private void buttonThemMHVaoDNH_Click(object sender, EventArgs e)
        {
            int result = DonNhapHangBUS.Instance.ThemCT_DNH(DonNhapHang.MaDNH, tbMaMH.Text, Int32.Parse(numericUpDownSLThem.Value.ToString()));

            if (result != 1)
            {
                MaterialMessageBox.Show("Thêm mặt hàng thất bại.", "Lỗi");
                return;
            }

            DonNhapHang.TongTien += Int32.Parse((numericUpDownDonGia.Value * numericUpDownSLThem.Value).ToString());

            result = DonNhapHangBUS.Instance.CapNhatDon(DonNhapHang);

            if (result != 1)
            {
                MaterialMessageBox.Show("Không lưu được đơn.", "Cảnh báo");
            }

            LoadFormDetail();
        }
    }
}
