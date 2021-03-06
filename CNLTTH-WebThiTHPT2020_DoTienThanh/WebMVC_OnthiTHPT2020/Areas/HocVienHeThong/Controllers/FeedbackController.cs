﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DAO;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;

namespace WebMVC_OnthiTHPT2020.Areas.HocVienHeThong.Controllers
{
    public class FeedbackController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<Feedback> item = FeedbackDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] Feedback x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            FeedbackDAO.Instance.Create(x.noidung, x.thoigiandang);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] Feedback x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            FeedbackDAO.Instance.Update(x.mafeedback, x.noidung, x.thoigiandang);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] int mafeedback)
        {
            if (mafeedback <= 0)
                return BadRequest("Not a valid feedback");
            FeedbackDAO.Instance.Delete(mafeedback);
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
