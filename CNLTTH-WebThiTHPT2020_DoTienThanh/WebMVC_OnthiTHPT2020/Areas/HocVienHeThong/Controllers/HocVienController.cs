using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DAO;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;
using System.Web.Routing;

namespace WebMVC_OnthiTHPT2020.Areas.HocVienHeThong.Controllers
{
    public class HocVienController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<HocVien> item = HocVienDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
