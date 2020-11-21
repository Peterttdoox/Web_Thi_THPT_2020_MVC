using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DTO
{
    public class ROLE_NAMES
    {
        public int ID_ROLE { get; set; }
        public string ROLE_NAME { get; set; }
        

        public ROLE_NAMES(DataRow row)
        {
            this.ID_ROLE = int.Parse(row["ID_ROLE"].ToString());
            this.ROLE_NAME = row["ROLE_NAME"].ToString();
        }

        public ROLE_NAMES(string ROLE_NAME)
        {
            this.ROLE_NAME = ROLE_NAME;
        }
        public ROLE_NAMES(int ID_ROLE, string ROLE_NAME)
        {
            this.ID_ROLE = ID_ROLE;
            this.ROLE_NAME = ROLE_NAME;
        }

        public ROLE_NAMES() { }
    }
}