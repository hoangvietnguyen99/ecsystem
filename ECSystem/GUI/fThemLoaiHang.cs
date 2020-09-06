using ECSystem.BUS;
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
    public partial class fThemLoaiHang : fMaterialSkin
    {
        private string maNV;
        public fThemLoaiHang(string maNV)
        {
            InitializeComponent();

            MaNV = maNV;
        }

        public string MaNV { get => maNV; set => maNV = value; }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbMaLH.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Vui lòng nhập mã loại hàng.", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (tbTenLH.Text.Length == 0)
            {
                MaterialMessageBox.Show(this, "Vui lòng nhập tên loại hàng.", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            LoaiHangBUS.Instance.ThemLoaiHang(tbMaLH.Text, tbTenLH.Text, MaNV);
            Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
