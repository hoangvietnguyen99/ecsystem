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
using ECSystem.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ECSystem.GUI
{
    public partial class fTrangBanHang : Form
    {
        string TenKHang = "", MaKHang = "";
        public fTrangBanHang(string maKH = null, string tenKH = null)
        {
            InitializeComponent();
            TenKHang = "Chào " + tenKH;
            MaKHang = maKH;
            loadQuanLySanPham(tenKH);
        }

        void loadQuanLySanPham(string tenKH)
        {
            tenKHang.Text = tenKH;
            loadLoaiHang();
            loadDSMatHang();
            loadDSTheoGiaTangDan();
            loadDSTheoGiaGiamDan();
            tenKHang.Text = TenKHang;
        }

        void loadLoaiHang()
        {
            List<LoaiHangDTO> dsLoai = new List<LoaiHangDTO>();

            dsLoai = LoaiHangDAO.Instance.LoadDSLoadHang();

            foreach (LoaiHangDTO item in dsLoai)
            {

                Button btn = new Button() { Width = 161, Height = 40 };
                btn.Text = item.TenLH;
                btn.Font = new Font(btn.Font.FontFamily, 10);
                btn.BackColor = Color.LightGoldenrodYellow;
                btn.Click += BtnLoaiHang_Click;
                btn.Tag = item;
                DanhMucSanPham.Controls.Add(btn);
            }
        }

        void loadDSMatHang()
        {
            try
            {
                List<MatHangDTO> dsMatHang = new List<MatHangDTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSMatHang");

                foreach (DataRow item in data.Rows)
                {
                    MatHangDTO mathang = new MatHangDTO(item);
                    dsMatHang.Add(mathang);
                }

                foreach (MatHangDTO item in dsMatHang)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 100;
                    pictureBox.Height = 100;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    DanhSachSanPham.Controls.Add(pictureBox);
                    pictureBox.ImageLocation = item.Img;

                    Button btn = new Button() { Width = 180, Height = 100 };
                    btn.Text = item.TenMH + Environment.NewLine + String.Format("{0:#,##0.##}", item.GiaTien) + " đ";
                    btn.Font = new Font(btn.Font.FontFamily, 10);
                    btn.Click += matHang_Click;
                    btn.Tag = item;
                    btn.BackColor = Color.LightCyan;
                    DanhSachSanPham.Controls.Add(btn);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối Database1");
            }
        }

        void loadDSTheoGiaTangDan()
        {
            var controls = DanhSachSanPham.Controls.OfType<MatHangDTO>().ToList();

            try
            {
                List<MatHangDTO> dsMatHang = new List<MatHangDTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSMatHangTangDan");

                foreach (DataRow item in data.Rows)
                {
                    MatHangDTO mathang = new MatHangDTO(item);
                    dsMatHang.Add(mathang);
                }

                foreach (MatHangDTO item in dsMatHang)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 100;
                    pictureBox.Height = 100;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    DSSanPhamTangDan.Controls.Add(pictureBox);
                    pictureBox.ImageLocation = item.Img;

                    Button btn = new Button() { Width = 180, Height = 100 };
                    btn.Text = item.TenMH + Environment.NewLine + String.Format("{0:#,##0.##}", item.GiaTien) + " đ";
                    btn.Font = new Font(btn.Font.FontFamily, 10);
                    btn.Click += matHang_Click;
                    btn.Tag = item;
                    btn.BackColor = Color.LightCyan;
                    DSSanPhamTangDan.Controls.Add(btn);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối Database");
            }
        }


        void loadDSTheoGiaGiamDan()
        {
            var controls = DanhSachSanPham.Controls.OfType<MatHangDTO>().ToList();

            try
            {
                List<MatHangDTO> dsMatHang = new List<MatHangDTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSMatHangGiaGiamDan");

                foreach (DataRow item in data.Rows)
                {
                    MatHangDTO mathang = new MatHangDTO(item);
                    dsMatHang.Add(mathang);
                }

                foreach (MatHangDTO item in dsMatHang)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 100;
                    pictureBox.Height = 100;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    DSSanPhamGiamDan.Controls.Add(pictureBox);
                    pictureBox.ImageLocation = item.Img;

                    Button btn = new Button() { Width = 180, Height = 100 };
                    btn.Text = item.TenMH + Environment.NewLine + String.Format("{0:#,##0.##}", item.GiaTien) + " đ";
                    btn.Font = new Font(btn.Font.FontFamily, 10);
                    btn.Click += matHang_Click;
                    btn.Tag = item;
                    btn.BackColor = Color.LightCyan;
                    DSSanPhamGiamDan.Controls.Add(btn);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối Database");
            }
        }

        void BtnLoaiHang_Click(object sender, EventArgs e)
        {
            string maLoaiHang = ((sender as Button).Tag as LoaiHangDTO).MaLH;
            string tenLoaiHang = ((sender as Button).Tag as LoaiHangDTO).TenLH;
            dynamicText.Text = tenLoaiHang;
            DanhSachSanPham.Controls.Clear();
            try
            {
                List<MatHangDTO> matHangTheoLoai = new List<MatHangDTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSMatHangTheoLoaiHang @maLoaiHang = '" + maLoaiHang + "'");

                foreach (DataRow item in data.Rows)
                {
                    MatHangDTO mathang = new MatHangDTO(item);
                    matHangTheoLoai.Add(mathang);
                }

                foreach (MatHangDTO item in matHangTheoLoai)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 100;
                    pictureBox.Height = 100;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    DanhSachSanPham.Controls.Add(pictureBox);
                    pictureBox.ImageLocation = item.Img;

                    Button btn = new Button() { Width = 180, Height = 100 };
                    btn.Text = item.TenMH + Environment.NewLine + String.Format("{0:#,##0.##}", item.GiaTien) + " đ";
                    btn.Font = new Font(btn.Font.FontFamily, 10);
                    btn.Tag = item;
                    btn.Click += matHang_Click;
                    btn.BackColor = Color.LightCyan;
                    DanhSachSanPham.Controls.Add(btn);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối Database");
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string temp = SearchBox.Text;
            DanhSachSanPham.Controls.Clear();
            if (temp != "")
            {
                try
                {
                    List<MatHangDTO> dsMatHang = new List<MatHangDTO>();
                    DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_TimMatHang @tenMH = " + temp);

                    foreach (DataRow item in data.Rows)
                    {
                        MatHangDTO mathang = new MatHangDTO(item);
                        dsMatHang.Add(mathang);
                    }

                    foreach (MatHangDTO item in dsMatHang)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        DanhSachSanPham.Controls.Add(pictureBox);
                        pictureBox.ImageLocation = item.Img;

                        Button btn = new Button() { Width = 180, Height = 100 };
                        btn.Text = item.TenMH + Environment.NewLine + String.Format("{0:#,##0.##}", item.GiaTien) + " đ";
                        btn.Font = new Font(btn.Font.FontFamily, 10);
                        btn.Tag = item;
                        btn.Click += matHang_Click;
                        btn.BackColor = Color.LightCyan;
                        DanhSachSanPham.Controls.Add(btn);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối Database");
                }
            }
            else
            {
                DanhSachSanPham.Controls.Clear();
                loadDSMatHang();
            }
        }


        private void timSPTrongKhoangGia_Click(object sender, EventArgs e)
        {
            double minValue = Convert.ToDouble(giaNhoNhat.Text);
            double maxValue = Convert.ToDouble(GiaCaoNhat.Text);

            try
            {
                List<MatHangDTO> dsMatHang = new List<MatHangDTO>();
                DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSMatHangTheoGia @minPrice =" + minValue + ", @maxPrice=" + maxValue);
                DanhSachSanPham.Controls.Clear();
                foreach (DataRow item in data.Rows)
                {
                    MatHangDTO mathang = new MatHangDTO(item);
                    dsMatHang.Add(mathang);
                }

                foreach (MatHangDTO item in dsMatHang)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 100;
                    pictureBox.Height = 100;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    DanhSachSanPham.Controls.Add(pictureBox);
                    pictureBox.ImageLocation = item.Img;

                    Button btn = new Button() { Width = 180, Height = 100 };
                    btn.Text = item.TenMH + Environment.NewLine + String.Format("{0:#,##0.##}", item.GiaTien) + " đ";
                    btn.Font = new Font(btn.Font.FontFamily, 10);
                    btn.Tag = item;
                    btn.Click += matHang_Click;
                    btn.BackColor = Color.LightCyan;
                    DanhSachSanPham.Controls.Add(btn);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối Database");
            }
        }

        void matHang_Click(object sender, EventArgs e)
        {
            string maMH = ((sender as Button).Tag as MatHangDTO).MaMH;
            fChiTietSanPham chiTietSanPham = new fChiTietSanPham(maMH, MaKHang);
            chiTietSanPham.ShowDialog();
        }


        private void nutDangNhap_Click(object sender, EventArgs e)
        {
            fDangNhap dangnhap = new fDangNhap();
            dangnhap.ShowDialog();
        }

        private void theoDoiDonHang_Click(object sender, EventArgs e)
        {
            if (TenKHang == null)
            {
                fDangNhap dangnhap = new fDangNhap();
                dangnhap.ShowDialog();
            }
            else
            {
                formTheoDoiSanPham theoDoiSP = new formTheoDoiSanPham(MaKHang, TenKHang);
                theoDoiSP.ShowDialog();
            }
        }
    }
}
