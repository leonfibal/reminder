using System;
using System.Web.Http;

namespace Reminder.Api.Controllers
{
    [RoutePrefix("test")]
    public class TestController : ApiController
    {

        [Route("")]
        [HttpGet]
        public IHttpActionResult Test()
        {
            return Ok(new
            {
                Message = "I am alive!",
                Date = DateTime.Now
            });
        }
    }
}