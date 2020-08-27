using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECSystem.BUS;
using ECSystem.DTO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ECSystem.GUI
{
    public partial class fQuanLyQuangCao : fMaterialSkin
    {
        private NhanVienDTO nhanVien;

        public NhanVienDTO NhanVien { get => nhanVien; set => nhanVien = value; }

        public fQuanLyQuangCao(NhanVienDTO nhanVien)
        {
            InitializeComponent();

            NhanVien = nhanVien;

            LoadDSTin();
        }

        private void btnThemQuangCao_Click(object sender, EventArgs e)
        {
            if (textBoxMaTin.Text.Length == 0 || mlTextBoxNoiDung.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Các thông tin phải được nhập đầy đủ.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int result = TinQuangCaoBUS.Instance.ThemTinQuangCao(textBoxMaTin.Text, mlTextBoxNoiDung.Text, DateTime.Now, NhanVien.MaNV);

                LoadDSTin();
            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadDSTin()
        {
            List<TinQuangCaoDTO> ds = TinQuangCaoBUS.Instance.XemDSTinQuangCao();

            dtgvDSTin.DataSource = ds;
        }

        private void dtgvDSTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                textBoxMaTin.Text = dgv.CurrentRow.Cells["MaTin"].Value.ToString();
                mlTextBoxNoiDung.Text = dgv.CurrentRow.Cells["NoiDung"].Value.ToString();
            }
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            if (textBoxMaTin.Text.Length == 0 || mlTextBoxNoiDung.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Các thông tin phải được nhập đầy đủ.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int result = TinQuangCaoBUS.Instance.CapNhatTinQuangCao(textBoxMaTin.Text, mlTextBoxNoiDung.Text, DateTime.Now, NhanVien.MaNV);

                LoadDSTin();
            }
        }

        private void buttonThemDoiTac_Click(object sender, EventArgs e)
        {
            if (textBoxMaTin.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Chọn một tin để từ bảng để thêm!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                fThemDoiTac form = new fThemDoiTac(textBoxMaTin.Text);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void fQuanLyQuangCao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MaterialMessageBox.Show(this, "Đồng ý đăng xuất?", "Cảnh báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            if (textBoxMaTin.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Các thông tin phải được nhập đầy đủ.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int result = TinQuangCaoBUS.Instance.XoaTinQuangCao(textBoxMaTin.Text);

                LoadDSTin();
            }
        }

        private void buttonThemKhachHang_Click(object sender, EventArgs e)
        {
            if (textBoxMaTin.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Chọn một tin để từ bảng để thêm!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                fThemKhachHang form = new fThemKhachHang(textBoxMaTin.Text);
                Hide();
                form.ShowDialog();
                Show();            
            }
        }
    }
}