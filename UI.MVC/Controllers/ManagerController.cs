using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.MVC.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult First()
        {
            return View();
        }
    }
}
