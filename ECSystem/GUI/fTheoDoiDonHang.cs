using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECSystem.DTO;
using ECSystem.DAO;

namespace ECSystem.GUI
{
    public partial class formTheoDoiSanPham : Form
    {
        public formTheoDoiSanPham(string maKH, string tenKH)
        {
            InitializeComponent();
            loadTheoDoiDonHang(maKH);
        }

        void loadTheoDoiDonHang(string maKH)
        {
            CT_HoaDon.DataSource = DataProvider.Instance.ExecuteQuery("EXEC USP_LichSuMuaHangTheoMaKH @maKH = '" + maKH + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
