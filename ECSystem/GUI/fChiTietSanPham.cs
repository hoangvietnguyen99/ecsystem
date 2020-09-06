using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECSystem.DAO;
using ECSystem.DTO;

namespace ECSystem.GUI
{
    public partial class fChiTietSanPham : Form
    {
        string maKHang;
        public fChiTietSanPham(string maMH, string maKH)
        {
            InitializeComponent();
            maKHang = maKH;
            loadSPInfo(maMH);
        }
        string masp, tensp;
        double giatien;
        int slmua, slton;
        void loadSPInfo(string maMH)
        {
            try
            {
                MatHangDTO sp;
                DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSMatHangTheoMa  @MaMH = '" + maMH + "'");

                foreach (DataRow item in data.Rows)
                {
                    sp = new MatHangDTO(item);
                    ten_mh.Text = sp.TenMH;
                    giaTien.Text = String.Format("{0:#,##0.##}", sp.GiaTien) + " đ";
                    giaTien.ForeColor = Color.Salmon;
                    sl_ton.Text = sp.SLTon.ToString();

                    HinhAnh.Width = 220;
                    HinhAnh.Height = 220;
                    HinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    HinhAnh.ImageLocation = sp.Img;

                    masp = sp.MaMH;
                    tensp = sp.TenMH;
                    giatien = sp.GiaTien;
                    slton = sp.SLTon;
                }
            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI! ");
            }
        }

        private void quayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sl_ton_Click(object sender, EventArgs e)
        {

        }

        private void muaHang_Click(object sender, EventArgs e)
        {
            if (soLuongMua.Text == "")
                MessageBox.Show("Bạn phải chọn số lượng để mua", "Thông Báo", MessageBoxButtons.OK);
            else if (Int32.Parse(soLuongMua.Text) > slton)
            {
                MessageBox.Show("Số lượng mua lớn hơn số lượng hiện có. Vui lòng đặt với số lượng ít hơn.", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                if (maKHang == null)
                {
                    fDangNhap dangnhap = new fDangNhap();
                    dangnhap.ShowDialog();
                }
                else
                {
                    slmua = Int32.Parse(soLuongMua.Text);
                    DatHang dathang = new DatHang(masp, slmua, maKHang);
                    dathang.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
