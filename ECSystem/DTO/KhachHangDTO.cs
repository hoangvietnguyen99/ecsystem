using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class KhachHangDTO
    {
        private string maKH;

        private string tenKH;

        private string email;

        private string diaChi;

        private string sDT;

        private string username;

        private string password;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Username { get => username; set => username = value; }

        public string Password { get => password; set => password = value; }

        public KhachHangDTO(string maKH, string tenKH, string email, string diaChi, string sDT, string password)
        {
            MaKH = maKH;
            TenKH = tenKH;
            Email = email;
            DiaChi = diaChi;
            SDT = sDT;
            Username = username;
            Password = password;
        }

        public KhachHangDTO(DataRow row)
        {
            MaKH = row["MaKH"].ToString();
            TenKH = row["TenKH"].ToString();
            Email = row["Email"].ToString();
            DiaChi = row["DiaChi"].ToString();
            SDT = row["SDT"].ToString();
            Username = row["Username"].ToString();
            Password = row["Password"].ToString();
        }
    }
}
