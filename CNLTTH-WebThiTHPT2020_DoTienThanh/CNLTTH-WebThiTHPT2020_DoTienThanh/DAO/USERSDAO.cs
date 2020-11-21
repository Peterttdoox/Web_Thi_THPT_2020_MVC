using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DAO
{
    public class USERSDAO
    {
        private USERSDAO() { }

        private static volatile USERSDAO instance;

        static object key = new object();

        public static USERSDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new USERSDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<USERS> GetList()
        {
            List<USERS> list = new List<USERS>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.USERS");
            foreach (DataRow item in data.Rows)
            {
                USERS obj = new USERS(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(int id, string email, string fullname, int sdt)
        {
            string query = $"INSERT dbo.USERS VALUES  ( N'{id}',  N'{email}', N'{fullname}', N'{sdt}')";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int id, string email, string fullname, int sdt)
        {
            string query = $"UPDATE dbo.USERS SET EMAIL=N'{email}' ID_USER={id} FULLNAME={fullname} SDT={sdt}";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }
        public int Delete(int id)
        {
            string query = $"DELETE dbo.USERS WHERE ID_USER={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}