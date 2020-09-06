using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class KhachHangDAO
    {
        private KhachHangDAO() { }

        private static KhachHangDAO instance;

        public static KhachHangDAO Instance 
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set => instance = value;
        }

        public KhachHangDTO LayKhachHang(string maKH)
        {
            string query = "USP_XemKhachHang @MaKH";

            KhachHangDTO kh = null;

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maKH });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                kh = new KhachHangDTO(row);
            }

            return kh;
        }

        public List<KhachHangDTO> LoadDSLoadKhachHang()
        {
            List<KhachHangDTO> khachHangList = new List<KhachHangDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSKhachHang");

            foreach (DataRow item in data.Rows)
            {
                KhachHangDTO khachhang = new KhachHangDTO(item);
                khachHangList.Add(khachhang);
            }
            return khachHangList;
        }

        public bool Login(string userName, string passWord)
        {
            string query = "EXEC USP_KhachHangLogin @userName  = N'" + userName + "', @passWord = N'" + passWord + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
