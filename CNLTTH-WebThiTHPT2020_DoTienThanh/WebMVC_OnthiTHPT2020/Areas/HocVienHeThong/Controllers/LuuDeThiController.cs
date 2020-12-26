using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DAO;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;

namespace WebMVC_OnthiTHPT2020.Areas.HocVienHeThong.Controllers
{
    public class LuuDeThiController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<LuuDeThi> item = LuuDeThiDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] LuuDeThi x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            LuuDeThiDAO.Instance.Create(x.ThoiDiemLuu, x.TrangThai);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] LuuDeThi x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            LuuDeThiDAO.Instance.Update(x.MaLuuDeThi, x.ThoiDiemLuu, x.TrangThai);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] int MaLuuDeThi)
        {
            if (MaLuuDeThi <= 0)
                return BadRequest("Not a valid feedback");
            LuuDeThiDAO.Instance.Delete(MaLuuDeThi);
            return Ok();
        }

        [HttpGet]
        //public IHttpActionResult TimKiemDeThi([FromUri] string madethi, string tendethi)
        //{
        //    List<Feedback> item = FeedbackDAO.Instance.TimKiemDeThi(madethi, tendethi);
        //    if (item.Count == 0)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(item);
        //}
    }
}
