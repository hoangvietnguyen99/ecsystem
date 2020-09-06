using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class MatHangDAO
    {
        private MatHangDAO() { }

        private static MatHangDAO instance;

        public static MatHangDAO Instance 
        {
            get { if (instance == null) instance = new MatHangDAO(); return instance; }
            private set => instance = value; 
        }

        public List<MatHangDTO> LayDSMatHang()
        {
            List<MatHangDTO> ds = new List<MatHangDTO>();

            string query = "USP_LayDSMatHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ds.Add(new MatHangDTO(row));
                }
            }

            return ds;
        }

        public List<MatHangDTO> LayDSMatHangTheoLoaiHang(string tenLoai)
        {
            List<MatHangDTO> ds = new List<MatHangDTO>();

            string query = "USP_LayDSMatHangTheoTenLoaiHang @TenLH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tenLoai });

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ds.Add(new MatHangDTO(row));
                }
            }

            return ds;
        }

        public int ThemMatHang(MatHangDTO mh)
        {
            string query = "USP_ThemMatHang @MaMH , @TenMH , @GiaTien , @SLTon , @LoaiHang";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mh.MaMH, mh.TenMH, mh.GiaTien, mh.SLTon, mh.LoaiHang });

            return result;
        }

        public MatHangDTO LayDSMatHang(string maMH)
        {
            string query = "SELECT * FROM MAT_HANG WHERE MaMH = '" + maMH + "'";

            MatHangDTO matHangDTO = null;

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                matHangDTO = new MatHangDTO(dataTable.Rows[0]);
            }

            return matHangDTO;
        }

        public void CapNhatSoLuongTon(string maMH, int soLuongMua)
        {          
            DataProvider.Instance.ExecuteQuery("EXEC USP_CapNhatSoLuongTon @maMH = N'" + maMH + "', @soluongMua = " + soLuongMua);
        }

        public LoaiHangDTO LayLoaiHang(string maMH)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM LOAI_HANG WHERE MaLH IN (SELECT LoaiHang FROM MAT_HANG WHERE MaMH = '" + maMH + "')");

            LoaiHangDTO loaiHangDTO = null;
            if (data.Rows.Count > 0)
            {
                loaiHangDTO = new LoaiHangDTO(data.Rows[0]);
            }

            return loaiHangDTO;
        }
    }
}
