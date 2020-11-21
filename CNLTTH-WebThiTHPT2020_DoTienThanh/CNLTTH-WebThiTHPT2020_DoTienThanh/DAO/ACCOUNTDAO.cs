using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DAO
{
    public class ACCOUNTDAO
    {
        private ACCOUNTDAO() { }

        private static volatile ACCOUNTDAO instance;

        static object key = new object();

        public static ACCOUNTDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new ACCOUNTDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<ACCOUNT> GetList()
        {
            List<ACCOUNT> list = new List<ACCOUNT>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ACCOUNT");
            foreach (DataRow item in data.Rows)
            {
                ACCOUNT obj = new ACCOUNT(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(int id_account, int id_user, string username, string pass)
        {
            string query = $"INSERT dbo.ACCOUNT VALUES  ( {id_account}, {id_user},  N'{username}', N'{pass}')";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int id_account, int id_user, string username, string pass)
        {
            string query = $"UPDATE dbo.ACCOUNT SET USERNAME=N'{username}' ID_ACCOUNT={id_account} ID_USER={id_user} PASS=N'{pass}' ";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }
        public int Delete(int id)
        {
            string query = $"DELETE dbo.ACCOUNT WHERE ID_ACCOUNT={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}