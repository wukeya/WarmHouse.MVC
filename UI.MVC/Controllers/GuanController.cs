using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.MVC.Controllers
{
    public class GuanController : Controller
    {
        //显示商品
        public IActionResult GoodShow()
        {
            return View();
        }
        //添加商品
        public IActionResult GoodAdd()
        {
            return View();
        }
        //采购
        public IActionResult Purchase()
        {
            return View();
        }
        //入库
        public IActionResult RuKu()
        {
            return View();
        }
        //出库
        public IActionResult ChuKu()
        {
            return View();
        }
        //设备显示
        public IActionResult EquipmentShow()
        {
            return View();
        }
        //设备显示
        public IActionResult EquipmentAdd()
        {
            return View();
        }
        //设备详情
        public IActionResult EquipmentDeit()
        {
            return View();
        }
        //报损添加
        public IActionResult ReportAdd()
        {
            return View();
        }
        //报损显示
        public IActionResult ReportShow()
        {
            return View();
        }
        //仓库添加
        public IActionResult WarmHouseAdd()
        {
            return View();
        }
        //仓库显示
        public IActionResult WarmHouseShow()
        {
            return View();
        }
        //盘点显示
        public IActionResult CheckShow() 
        {
            return View();
        }
    }
}
