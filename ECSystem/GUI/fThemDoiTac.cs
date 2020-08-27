using ECSystem.BUS;
using ECSystem.DAO;
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
    public partial class fThemDoiTac : fMaterialSkin
    {
        private string maTin;
        public fThemDoiTac(string maTin)
        {
            InitializeComponent();

            MaTin = maTin;

            textBoxMaTin.Text = MaTin;

            cbbMaDoiTac.DataSource = TinQuangCaoBUS.Instance.LayDSMaDoiTacChuaThem(MaTin);

            mlTextBoxNoiDung.Text = TinQuangCaoBUS.Instance.XemTinQuangCao(MaTin).NoiDung;

            dtgvDSDTDaThem.DataSource = TinQuangCaoDoiTacBUS.Instance.LayDSTinQCKHTheoTin(MaTin);
        }

        public string MaTin { get => maTin; set => maTin = value; }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (cbbMaDoiTac.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Chọn một đối tác để thêm!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (textBoxTTVTD.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Vui lòng nhập mô tả vị trí đặt!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (numericUpDownTGQC.Value == 0)
            {
                MaterialMessageBox.Show(this, "Vui lòng nhập thời gian đặt!", "Thông báo", MessageBoxButtons.OK);   
                return;
            }
            TinQuangCaoBUS.Instance.ThemDoiTac(MaTin, cbbMaDoiTac.Text, (int)numericUpDownTGQC.Value, textBoxTTVTD.Text);

            dtgvDSDTDaThem.DataSource = TinQuangCaoDoiTacBUS.Instance.LayDSTinQCKHTheoTin(MaTin);

            cbbMaDoiTac.DataSource = TinQuangCaoBUS.Instance.LayDSMaDoiTacChuaThem(MaTin);
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgvDSDTDaThem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                DoiTacDTO dt = DoiTacBUS.Instance.LayDoiTac(dgv.CurrentRow.Cells["MaDoiTac"].Value.ToString());
                textBoxDiaChi.Text = dt.DiaChi;
                textBoxMaDT.Text = dt.MaDoiTac;
                textBoxTenDT.Text = dt.TenDoiTac;
                textBoxSDT.Text = dt.SDT;
                mlTextBoxDanhGia.Text = dt.DanhGia;
                textBoxSoLanGiaHan.Text = dt.SoLanGiaHan.ToString();

            }
        }
    }
}
