using CNLTTH_WebThiTHPT2020_DoTienThanh.DAO;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using System.Web.Mvc;
using System.Web.Routing;


namespace CNLTTH_WebThiTHPT2020_DoTienThanh.Controllers
{
    public class ROLE_NAMESController : ApiController
    {
        [Route("api/ROLE_NAMES")]
        public IHttpActionResult Get()
        {
            List<ROLE_NAMES> item = ROLE_NAMESDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [Route("api/ROLE_NAMES")]
        public IHttpActionResult Post([FromBody] ROLE_NAMES x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            ROLE_NAMESDAO.Instance.Create(x.ID_ROLE, x.ROLE_NAME);
            return Ok();
        }

        [Route("api/ROLE_NAMES")]
        public IHttpActionResult Put([FromBody] ROLE_NAMES x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            ROLE_NAMESDAO.Instance.Update(x.ID_ROLE, x.ROLE_NAME);
            return Ok();
        }

        [Route("api/ROLE_NAMES/{id}")]
        public IHttpActionResult Delete([FromUri] int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid ROLE_NAMES id");
            ROLE_NAMESDAO.Instance.Delete(id);
            return Ok();
        }
    }
}
