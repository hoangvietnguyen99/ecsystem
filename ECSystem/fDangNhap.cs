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

namespace ECSystem
{
    public partial class fDangNhap : MaterialForm
    {
        public fDangNhap()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void formDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MaterialMessageBox.Show(this, "Bạn có chắc muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textboxUsername.Text;
            string password = textBoxPassword.Text;

            NhanVien nv = GetNhanVien(username);

            if (nv != null && nv.Password == password)
            {
                if (nv.ChucVu == "Nhập hàng")
                {
                    fQuanLyMatHang form = new fQuanLyMatHang();
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MaterialMessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại", MessageBoxButtons.OK);
            }
        }

        private NhanVien GetNhanVien(string username)
        {
            return NhanVienDAO.Instance.GetNhanVien(username);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
