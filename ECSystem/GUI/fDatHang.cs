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
    public partial class DatHang : Form
    {
        public DatHang(string maMH, int slmua, string maKH)
        {
            InitializeComponent();
            makh = maKH;
            loadSPMua(maMH, slmua);
        }

        string masp, tensp, makh;
        double giatien, thanh_tien;
        int soluong, slgmua;
        void loadSPMua(string maMH, int slmua)
        {

            try
            {
                MatHangDTO sp;
                DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSMatHangTheoMa  @MaMH = '" + maMH + "'");

                foreach (DataRow item in data.Rows)
                {
                    sp = new MatHangDTO(item);
                    tenMH.Text = sp.TenMH;
                    giaTien.Text = String.Format("{0:#,##0.##}", sp.GiaTien) + " đ";
                    soLuong.Text = slmua.ToString();
                    thanh_tien = sp.GiaTien * slmua;
                    thanhTien.Text = String.Format("{0:#,##0.##}", thanh_tien) + " đ";

                    hinhAnh.Width = 220;
                    hinhAnh.Height = 220;
                    hinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    hinhAnh.ImageLocation = sp.Img;

                    masp = sp.MaMH;
                    tensp = sp.TenMH;
                    giatien = sp.GiaTien;
                    soluong = sp.SLTon;
                    slgmua = slmua;
                }
            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI! ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nutMua_Click(object sender, EventArgs e)
        {
            string ma_HoaDon = HoaDonDAO.Instance.TaoHoaDonID();

            HoaDonDAO.Instance.insertHoaDon(ma_HoaDon, thanh_tien, makh);

            CT_HoaDonDAO.Instance.insertCT_HoaDon(ma_HoaDon, masp, giatien, soluong);

            MatHangDAO.Instance.CapNhatSoLuongTon(masp, slgmua);

            MessageBox.Show("Đặt Hàng Thành Công !!!!", "Thông Báo", MessageBoxButtons.OK);

            this.Close();
        }
    }
}
