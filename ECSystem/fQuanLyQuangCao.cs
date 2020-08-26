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
    public partial class fQuanLyQuangCao : MaterialForm
    {
        private NhanVien nhanVien;

        public NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }

        public fQuanLyQuangCao(NhanVien nhanVien)
        {
            InitializeComponent();

            NhanVien = nhanVien;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            LoadDSTin();
        }

        private void btnThemQuangCao_Click(object sender, EventArgs e)
        {
            TinQuangCao tin = new TinQuangCao(textBoxMaTin.Text, mlTextBoxNoiDung.Text, DateTime.Now, NhanVien.MaNV);

            bool result = TinQuangCaoDAO.Instance.KiemTraTinQuangCao(tin);

            LoadDSTin();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadDSTin()
        {
            List<TinQuangCao> ds = TinQuangCaoDAO.Instance.LoadTinQuangCao();

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
            TinQuangCao tin = new TinQuangCao(textBoxMaTin.Text, mlTextBoxNoiDung.Text, DateTime.Now, NhanVien.MaNV);

            bool result = TinQuangCaoDAO.Instance.KiemTraTinQuangCao(tin);

            LoadDSTin();
        }

        private void buttonThemDoiTac_Click(object sender, EventArgs e)
        {
            fXemDoiTac form = new fXemDoiTac();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
