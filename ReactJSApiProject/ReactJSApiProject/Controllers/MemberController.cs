using ReactJSApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReactJSApiProject.Controllers
{

    public class MemberController : ApiController
    {
        Model1 db = new Model1();

        [HttpGet]
        public IHttpActionResult GetMember()
        {
            List<Members> members= db.Members.Where(x => x.IsActive == true).ToList();

            return Ok(members);
        }
    }
}
