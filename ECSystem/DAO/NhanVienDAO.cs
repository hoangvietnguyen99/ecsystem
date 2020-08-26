using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class NhanVienDAO
    {
        private NhanVienDAO() { }

        private static NhanVienDAO instance;

        public static NhanVienDAO Instance {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set => instance = value;
        }

        public NhanVien GetNhanVien(string username)
        {
            string query = "USP_GetNhanVienByMaNV @username";

            NhanVien nhanVien = null;

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                nhanVien = new NhanVien(row);
            }

            return nhanVien;
        }
    }
}
