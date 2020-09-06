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
using MaterialSkin;
using MaterialSkin.Controls;

namespace ECSystem.GUI
{
    public partial class fDangNhap : fMaterialSkin
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textboxUsername.Text;
            string password = textBoxPassword.Text;

            NhanVienDTO nv = GetNhanVien(username);

            if (nv != null && nv.Password == password)
            {
                if (nv.ChucVu == "Mặt hàng")
                {
                    fQuanLyMatHang form = new fQuanLyMatHang(nv.MaNV);
                    Hide();
                    form.ShowDialog();
                    Show();
                }
                else if (nv.ChucVu == "Quản lý")
                {
                    fQuanLy form = new fQuanLy(nv.MaNV);
                    Hide();
                    form.ShowDialog();
                    Show();
                }
                else if (nv.ChucVu == "Quảng cáo")
                {
                    fQuanLyQuangCao form = new fQuanLyQuangCao(nv);
                    Hide();
                    form.ShowDialog();
                    Show();
                }
                else
                {
                    MaterialMessageBox.Show(this, "Tính năng chưa phát triển.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MaterialMessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại", MessageBoxButtons.OK);
            }
        }

        private NhanVienDTO GetNhanVien(string username)
        {
            return NhanVienDAO.Instance.GetNhanVien(username);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MaterialMessageBox.Show(this, "Đồng ý thoát chương trình?", "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void KhachHangLogin_Button_Click(object sender, EventArgs e)
        {
            string passWord = textBoxPassword.Text;
            string userName = textboxUsername.Text;
            if (Login_KhachHang(userName, passWord))
            {
                textBoxPassword.Clear();
                string query = "EXEC USP_KhachHangLogin @userName = N'" + userName + "',  @passWord ='" + passWord + "'";
                DataTable kq = DataProvider.Instance.ExecuteQuery(query);
                DataRow row = kq.Rows[0];
                string maKh = row["MaKH"].ToString();
                string tenKh = row["TenKH"].ToString();
                fTrangBanHang form = new fTrangBanHang(maKh, tenKh);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        bool Login_KhachHang(string userName, string passWord)
        {
            return KhachHangDAO.Instance.Login(userName, passWord);
        }
    }
}
