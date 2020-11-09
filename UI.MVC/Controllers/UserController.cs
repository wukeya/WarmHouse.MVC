using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //注册
        public IActionResult Login()
        {
            return View();
        }

        //首页
        public IActionResult First()
        {
            return View();
        }
    }
}
