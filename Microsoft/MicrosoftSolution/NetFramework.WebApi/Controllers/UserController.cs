using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NetFramework.WebApi.Controllers
{
    public class UserController : ApiController
    {
        private readonly IAuthService _authService;

        public UserController(IAuthService authService)
        {
            _authService = authService;
        }

        public IHttpActionResult GetName()
        {            
            return Ok(_authService.GetName());
        }
    }
}
