using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend.Controllers
{
    public class AuthController : ApiController
    {
        [HttpGet]
        public bool SetAuth(string id)
        {
            /*Set cookie*/
            return true;
        }

        [HttpGet]
        public string GetName(string id)
        {
            FacebookClient fbClient = new FacebookClient(id);
            dynamic me = fbClient.Get("me");
            return me.name;
        }
    }
}
