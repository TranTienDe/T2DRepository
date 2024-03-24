using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFramework.WebApi
{
    public class AuthService : IAuthService
    {
        public string GetName()
        {
            return "Chúng tôi là chiến sĩ!";
        }
    }
}