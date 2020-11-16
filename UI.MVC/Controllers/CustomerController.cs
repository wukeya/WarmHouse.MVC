using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerFirst() 
        {
            return View();
        }
        //选购商品
        public IActionResult SelectOrderAdd() 
        {
            ViewBag.time = DateTime.Now;
            return View();
        }
        //选购清单显示
        public IActionResult SelectOrderShow() 
        {
            return View();
        }
        //选购清单详情显示
        public IActionResult SelectOrderDeitShow(int id)
        {
            ViewBag.sid = id;
            return View();
        }
    }
}
