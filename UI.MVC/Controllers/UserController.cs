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
        //登录页面
        //首页
        public IActionResult First()
        {
            return View();
        }

        //--------------------

        //一对多添加
        public IActionResult ADD()
        {
            return View();
        }
        //审核
        public IActionResult Audit()
        {
            return View();
        }
        //入库
        public IActionResult EnterLibrary()
        {
            return View();

        }
        //出库
        public IActionResult OutLibrary()
        {
            return View();

        }
        //调库
        public IActionResult ChangeLibrary()
        {
            return View();

        }
        //报损
        public IActionResult Breakage()
        {
            return View();

        }
    }
}
