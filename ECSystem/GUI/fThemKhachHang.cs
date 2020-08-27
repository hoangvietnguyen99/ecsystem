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
    public partial class fThemKhachHang : fMaterialSkin
    {
        private string maTin;
        public fThemKhachHang(string maTin)
        {
            InitializeComponent();

            MaTin = maTin;

            textBoxMaTin.Text = maTin;

            cbbMaKH.DataSource = TinQuangCaoBUS.Instance.LayDSMaKhachHangChuaThem(MaTin);

            mlTextBoxNoiDung.Text = TinQuangCaoBUS.Instance.XemTinQuangCao(MaTin).NoiDung;

            dtgvDSKHDaThem.DataSource = TinQuangCaoKhachHangBUS.Instance.LayDSTinQCKHTheoTin(MaTin);
        }

        public string MaTin { get => maTin; set => maTin = value; }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (cbbMaKH.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Chọn một khách hàng để thêm!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            TinQuangCaoBUS.Instance.ThemKhachHang(MaTin, cbbMaKH.Text);
            dtgvDSKHDaThem.DataSource = TinQuangCaoKhachHangBUS.Instance.LayDSTinQCKHTheoTin(MaTin);
            cbbMaKH.DataSource = TinQuangCaoBUS.Instance.LayDSMaKhachHangChuaThem(MaTin);
        }

        private void dtgvDSKHDaThem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                KhachHangDTO kh = KhachHangBUS.Instance.LayKhachHang(dgv.CurrentRow.Cells["MaKH"].Value.ToString());
                textBoxMaKH.Text = kh.MaKH;
                textBoxTenKH.Text = kh.TenKH;
                textBoxEmail.Text = kh.Email;
                textBoxDiaChi.Text = kh.DiaChi;
                textBoxSDT.Text = kh.SDT;
            }
        }
    }
}
