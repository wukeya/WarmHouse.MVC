using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.MVC.Controllers
{
    public class DenLuController : Controller
    {
        //登录
        public IActionResult UserdDenLuint()
        {
            return View();
        }
        //注册
        public IActionResult UserdZhuCe()
        {
            return View();
        }
    }
}