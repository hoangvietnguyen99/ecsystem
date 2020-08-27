using ECSystem.DTO;
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
        }

        public string MaNV { get => maNV; set => maNV = value; }
    }
}
