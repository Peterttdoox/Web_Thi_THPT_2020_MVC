using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DAO;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using System.Web.Mvc;
using System.Web.Routing;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.Controllers
{
    public class ACCOUNTController : ApiController
    {
        [Route("api/ACCOUNT")]
        public IHttpActionResult Get()
        {
            List<ACCOUNT> item = ACCOUNTDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [Route("api/ACCOUNT")]
        public IHttpActionResult Post([FromBody] ACCOUNT x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            ACCOUNTDAO.Instance.Create(x.ID_ACCOUNT, x.ID_USER, x.USERNAME, x.PASS);
            return Ok();
        }

        [Route("api/ACCOUNT")]
        public IHttpActionResult Put([FromBody] ACCOUNT x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            ACCOUNTDAO.Instance.Update(x.ID_ACCOUNT, x.ID_USER, x.USERNAME, x.PASS);
            return Ok();
        }

        [Route("api/ACCOUNT/{id}")]
        public IHttpActionResult Delete([FromUri] int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid ACCOUNT id");
            ACCOUNTDAO.Instance.Delete(id);
            return Ok();
        }



    }
}
