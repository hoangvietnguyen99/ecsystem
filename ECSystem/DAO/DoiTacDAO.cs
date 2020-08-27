﻿using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class DoiTacDAO
    {
        private DoiTacDAO() { }

        private static DoiTacDAO instance;

        public static DoiTacDAO Instance 
        {
            get { if (instance == null) instance = new DoiTacDAO(); return instance; }
            private set => instance = value;
        }

        public DoiTacDTO LayDoiTac(string maKH)
        {
            string query = "USP_XemDoiTac @MaKH";

            DoiTacDTO dt = null;

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maKH });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                dt = new DoiTacDTO(row);
            }

            return dt;
        }
    }
}
