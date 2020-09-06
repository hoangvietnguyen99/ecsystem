using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class LoaiHangDAO
    {
        private LoaiHangDAO() { }

        private static LoaiHangDAO instance;

        public static LoaiHangDAO Instance
        {
            get { if (instance == null) instance = new LoaiHangDAO(); return instance; }
            private set => instance = value;
        }

        public List<LoaiHangDTO> LoadDSLoadHang()
        {
            List<LoaiHangDTO> loaiHangList = new List<LoaiHangDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSLoaiHang");

            foreach (DataRow item in data.Rows)
            {
                LoaiHangDTO dsLoai = new LoaiHangDTO(item);
                loaiHangList.Add(dsLoai);
            }
            return loaiHangList;
        }

        public List<string> LayDSTenLoaiHang()
        {
            List<string> ds = new List<string>();

            string query = "USP_LayDSTenLoaiHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ds.Add(row["TenLH"].ToString());
                }
            }

            return ds;
        }

        public LoaiHangDTO LayLoaiHangTheoTen(string tenLH)
        {
            string query = "USP_LayLoaiHangTheoTen @tenLH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenLH });

            if (data.Rows.Count > 0)
            {
                return new LoaiHangDTO(data.Rows[0]);
            }

            return null;
        }

        public int ThemLoaiHang(LoaiHangDTO lh)
        {
            string query = "USP_ThemLoaiHang @MaLH , @TenLH , @NVQuanLy";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { lh.MaLH, lh.TenLH, lh.NhanVienQL });

            return result;
        }

        public int XoaLoaiHang(string maLH)
        {
            string query = "USP_XoaLoaiHang @MaLH";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maLH });

            return result;
        }
    }
}
