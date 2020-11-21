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
    public class USERSController : ApiController
    {
        [Route("api/USERS")]
        public IHttpActionResult Get()
        {
            List<USERS> item = USERSDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [Route("api/USERS")]
        public IHttpActionResult Post([FromBody] USERS x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            USERSDAO.Instance.Create(x.ID_USER, x.EMAIL, x.FULLNAME, x.SDT);
            return Ok();
        }

        [Route("api/USERS")]
        public IHttpActionResult Put([FromBody] USERS x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            USERSDAO.Instance.Update(x.ID_USER, x.EMAIL, x.FULLNAME, x.SDT);
            return Ok();
        }

        [Route("api/USERS/{id}")]
        public IHttpActionResult Delete([FromUri] int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid USERS id");
            USERSDAO.Instance.Delete(id);
            return Ok();
        }


       
    }
}
