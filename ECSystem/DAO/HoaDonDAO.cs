using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO();
                return HoaDonDAO.instance;
            }
            private set { HoaDonDAO.instance = value; }
        }

        private HoaDonDAO() { }

        public List<HoaDon> LoadDSLoadHoaDon()
        {
            List<HoaDon> hoaDonList = new List<HoaDon>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSCTHoaDon");

            foreach (DataRow item in data.Rows)
            {
                HoaDon hoadon = new HoaDon(item);
                hoaDonList.Add(hoadon);
            }
            return hoaDonList;
        }

        public string TaoHoaDonID()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSHoaDonHienCo");
            if (dataTable.Rows.Count == 0)
                return "HD001";
            else
            {
                string bill_last = dataTable.Rows[0][0].ToString().Substring(2, 3);
                int lastBillID = Convert.ToInt32(bill_last);
                lastBillID++;
                string bill_id_created = "HD" + lastBillID.ToString("000");
                return bill_id_created;
            }
        }

        public void insertHoaDon(string maHD, double tongtien, string maKH)
        {
            //DataProvider.Instance.ExecuteQuery("INSERT INTO HOA_DON VALUES ('" "', GETDATE(), "  ", NULL, NULL, NULL, NULL, '"  "')");
            DataProvider.Instance.ExecuteQuery("EXEC USP_ThemHoaDon @maHD ='" + maHD + "', @tongTien =" + tongtien + ", @maKH = '" + maKH + "'");
        }

    }
}
