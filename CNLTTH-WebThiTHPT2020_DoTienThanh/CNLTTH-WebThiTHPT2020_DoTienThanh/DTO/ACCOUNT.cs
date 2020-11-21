using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DTO
{
    public class ACCOUNT
    {
        public int ID_ACCOUNT { get; set; }
        public int ID_USER { get; set; }
        public string USERNAME { get; set; }
        public string PASS { get; set; }

        public ACCOUNT(DataRow row)
        {
            this.ID_ACCOUNT = int.Parse(row["ID_ACCOUNT"].ToString());
            this.ID_USER = int.Parse(row["ID_USER"].ToString());
            this.USERNAME = row["USERNAME"].ToString();
            this.PASS = row["PASS"].ToString();
        }

        public ACCOUNT(string USERNAME, string PASS)
        {
            this.USERNAME = USERNAME;
            this.PASS = PASS;
        }
        public ACCOUNT(int ID_ACCOUNT, int ID_USER, string USERNAME, string PASS)
        {
            this.ID_ACCOUNT = ID_ACCOUNT;
            this.ID_USER = ID_USER;
            this.USERNAME = USERNAME;
            this.PASS = PASS;
        }

        public ACCOUNT() {}
    }
}