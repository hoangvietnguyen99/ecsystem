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
    public partial class fNhapHang : fMaterialSkin
    {
        private MatHangDTO matHang;

        private string maNV;

        public fNhapHang(string maNV)
        {
            InitializeComponent();

            MaNV = maNV;

            LoadFormDetail();

            dateTimePickerNgayNhap.Value = DateTime.Now;
        }

        public fNhapHang(MatHangDTO matHangDTO, string maNV)
        {
            InitializeComponent();

            MaNV = maNV;

            MatHang = matHangDTO;

            LoadFormDetail();

            dateTimePickerNgayNhap.Value = DateTime.Now;
        }

        public MatHangDTO MatHang { get => matHang; set => matHang = value; }
        public string MaNV { get => maNV; set => maNV = value; }

        private void LoadFormDetail()
        {
            dataGridViewDonChuaDuyet.DataSource = DonNhapHangBUS.Instance.DSDonChuaDuyet(MaNV);

            LoadCBBNCC();
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            if (tbMaDonDH.TextLength == 0)
            {
                MaterialMessageBox.Show("Vui lòng điền mã đơn.", "Hướng dẫn");
                return;
            }

            DonNhapHangDTO donNhapHang = new DonNhapHangDTO(tbMaDonDH.Text, dateTimePickerNgayNhap.Value, mltbLyDo.Text, 0, MaNV, null, comboBoxNCC.Text);

            int result = DonNhapHangBUS.Instance.ThemDon(donNhapHang);

            if (result != 1)
            {
                MaterialMessageBox.Show("Thêm đơn thất bại", "Cảnh báo");
                return;
            }

            MaterialMessageBox.Show("Đã thêm đơn " + donNhapHang.MaDNH, "Thành công");

            LoadFormDetail();
        }

        private void LoadCBBNCC()
        {
            comboBoxNCC.DataSource = NCCBUS.Instance.LayDSTenNCC();
        }

        private void buttonThemNCC_Click(object sender, EventArgs e)
        {
            fNCC f = new fNCC();

            f.ShowDialog();

            LoadCBBNCC();
        }

        private void buttonChonDon_Click(object sender, EventArgs e)
        {
            DonNhapHangDTO donNhapHang = DonNhapHangBUS.Instance.LayDonNhapHang(tbMaDonDH.Text);

            fChiTietDNH f = null;

            if (MatHang == null)
            {
                f = new fChiTietDNH(donNhapHang, MaNV);
            }
            else
            {
                f = new fChiTietDNH(donNhapHang, MatHang, MaNV);
            }

            f.ShowDialog();

            LoadFormDetail();
        }

        private void dataGridViewDonChuaDuyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                tbMaDonDH.Text = dgv.CurrentRow.Cells["MaDNH"].Value.ToString();
                dateTimePickerNgayNhap.Value = DateTime.Parse(dgv.CurrentRow.Cells["NgayNhap"].Value.ToString());
                mltbLyDo.Text = dgv.CurrentRow.Cells["LyDoNhapHang"].Value.ToString();
                string maNCC = dgv.CurrentRow.Cells["MaNCC"].Value.ToString();
            }
        }

        private void dataGridViewDonChuaDuyet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentCell.Selected)
            {
                tbMaDonDH.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["MaDNH"].Value.ToString();
                dateTimePickerNgayNhap.Value = DateTime.Parse(dgv.Rows[dgv.CurrentCell.RowIndex].Cells["NgayNhap"].Value.ToString());
                mltbLyDo.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["LyDoNhapHang"].Value.ToString();
                string maNCC = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["MaNCC"].Value.ToString();
            }
        }
    }
}
