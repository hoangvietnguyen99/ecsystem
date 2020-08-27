using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class NhanVienDTO
    {
        private string maNV;

        private string tenNV;

        private string diaChi;

        private string sDT;

        private string chucVu;

        private string password;

        public NhanVienDTO(string maNV, string tenNV, string diaChi, string sDT, string chucVu, string password)
        {
            MaNV = maNV;
            TenNV = tenNV;
            DiaChi = diaChi;
            SDT = sDT;
            ChucVu = chucVu;
            Password = password;
        }

        public NhanVienDTO(DataRow row)
        {
            MaNV = row["MaNV"].ToString();
            TenNV = row["TenNV"].ToString();
            DiaChi = row["DiaChi"].ToString();
            SDT = row["SDT"].ToString();
            ChucVu = row["ChucVu"].ToString();
            Password = row["Password"].ToString();
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Password { get => password; set => password = value; }
    }
}
