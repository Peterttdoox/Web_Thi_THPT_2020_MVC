using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DTO
{
    public class USERS
    {
        public int ID_USER { get; set; }
        public string EMAIL { get; set; }
        public string FULLNAME { get; set; }
        public int SDT { get; set; }

        public USERS(DataRow row)
        {
            this.ID_USER = int.Parse(row["ID_USER"].ToString());
            this.EMAIL = row["EMAIL"].ToString();
            this.FULLNAME = row["FULLNAME"].ToString();
            this.SDT = int.Parse(row["SDT"].ToString());
        }

        public USERS(string ROLE_NAME)
        {
            this.EMAIL = EMAIL;
            this.FULLNAME = FULLNAME;
            this.SDT = SDT;
        }
        public USERS(int ID_ROLE, string ROLE_NAME)
        {
            this.ID_USER = ID_USER;
            this.FULLNAME = FULLNAME;
            this.SDT = SDT;
        }

        public USERS() { }
    }
}