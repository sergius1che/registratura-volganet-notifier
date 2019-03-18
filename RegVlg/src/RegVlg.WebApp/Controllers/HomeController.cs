using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegVlg.WebApp.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "Hello, world!";
        }

        public string Login()
        {
            return "Login!";
        }

        [Authorize]
        public string IsAuth()
        {
            return "Success!";
        }
    }
}
