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
    public partial class fNCC : fMaterialSkin
    {
        public fNCC()
        {
            InitializeComponent();

            LoadDSNCC();
        }

        private void LoadDSNCC()
        {
            dataGridViewNCC.DataSource = NCCBUS.Instance.LayDSNCC();
        }

        private void dataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                textBoxMaNCC.Text = dgv.CurrentRow.Cells["MaNCC"].Value.ToString();
                textBoxTenNCC.Text = dgv.CurrentRow.Cells["TenNCC"].Value.ToString();
                multiLineTextBoxDiaChiNCC.Text = dgv.CurrentRow.Cells["DiaChi"].Value.ToString();
                textBoxSDTNCC.Text = dgv.CurrentRow.Cells["SDT"].Value.ToString();
            }
        }

        private void dataGridViewNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentCell.Selected)
            {
                textBoxMaNCC.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["MaNCC"].Value.ToString();
                textBoxTenNCC.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["TenNCC"].Value.ToString();
                multiLineTextBoxDiaChiNCC.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["DiaChi"].Value.ToString();
                textBoxSDTNCC.Text = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["SDT"].Value.ToString();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaNCC.TextLength == 0)
            {
                MaterialMessageBox.Show("Vui lòng nhập mã NCC", "Hướng dẫn");
                return;
            }

            NCCDTO nCC = new NCCDTO(textBoxMaNCC.Text, textBoxTenNCC.Text, multiLineTextBoxDiaChiNCC.Text, textBoxSDTNCC.Text);

            int result = NCCBUS.Instance.ThemNCC(nCC);

            if (result != 1)
            {
                MaterialMessageBox.Show("Chưa thêm được NCC " + nCC.MaNCC, "Thất bại");
                return;
            }

            LoadDSNCC();
        }
    }
}
