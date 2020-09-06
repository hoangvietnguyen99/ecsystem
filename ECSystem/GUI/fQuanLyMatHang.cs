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
    public partial class fQuanLyMatHang: fMaterialSkin
    {
        private string maNV;

        public fQuanLyMatHang(string maNV)
        {
            InitializeComponent();

            MaNV = maNV;

            LoadCBBLoaiHang();

            LoadDTGVMatHang();
        }

        private void LoadDTGVMatHang()
        {
            if (cbbLoaiHang.Text.Length == 0)
            {
                return;
            }
            dtgvDSMatHang.DataSource = MatHangBUS.Instance.LayDSMatHangTheoTenLoaiHang(cbbLoaiHang.Text);
        }

        public string MaNV { get => maNV; set => maNV = value; }

        private void cbbLoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDTGVMatHang();
        }

        private void dtgvDSMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                tbMaMH.Text = dgv.CurrentRow.Cells["MaMH"].Value.ToString();
                tbTenMH.Text = dgv.CurrentRow.Cells["TenMH"].Value.ToString();
                textBoxGiaTien.Text = dgv.CurrentRow.Cells["GiaTien"].Value.ToString();
                textBoxSoLuongTon.Text = dgv.CurrentRow.Cells["SLTon"].Value.ToString();
                LoaiHangDTO loaiHangDTO = MatHangBUS.Instance.LayLoaiHang(tbMaMH.Text);
                textBoxLHMH.Text = loaiHangDTO.MaLH + " " + loaiHangDTO.TenLH;
            }
        }

        private void btNhapHang_Click(object sender, EventArgs e)
        {
            fNhapHang form = new fNhapHang(MaNV);

            form.ShowDialog();

            LoadDTGVMatHang();

            LoadCBBLoaiHang();
        }

        private void LoadCBBLoaiHang()
        {
            List<string> dsLoaiHang = new List<string>() { "Tất cả" };

            List<string> temp = LoaiHangBUS.Instance.LayDSTenLoaiHang();

            foreach (string item in temp)
            {
                dsLoaiHang.Add(item);
            }

            cbbLoaiHang.DataSource = dsLoaiHang;
        }

        private void buttonNhapThemHang_Click(object sender, EventArgs e)
        {
            if (tbMaMH.TextLength == 0)
            {
                MaterialMessageBox.Show("Vui lòng chọn một mặt hàng!", "Hướng dẫn");
                return;
            }

            MatHangDTO matHang = MatHangBUS.Instance.LayMatHang(tbMaMH.Text);

            fNhapHang f = new fNhapHang(matHang, MaNV);

            f.ShowDialog();

            LoadDTGVMatHang();
        }

        private void dtgvDSMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentCell.Selected)
            {
                tbMaMH.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["MaMH"].Value.ToString();
                tbTenMH.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["TenMH"].Value.ToString();
                textBoxGiaTien.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["GiaTien"].Value.ToString();
                textBoxSoLuongTon.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["SLTon"].Value.ToString();
                LoaiHangDTO loaiHangDTO = MatHangBUS.Instance.LayLoaiHang(tbMaMH.Text);
                textBoxLHMH.Text = loaiHangDTO.MaLH + " " + loaiHangDTO.TenLH;
            }
        }
    }
}
