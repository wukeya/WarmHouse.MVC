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
        //商品详情
        public IActionResult GoodDeit(int id) 
        {
            ViewBag.id = id;
            return View();
        }
        //商品修改
        public IActionResult GoodUpdate(int id)
        {
            ViewBag.id = id;
            return View();
        }
        //采购
        public IActionResult Purchase()
        {
            
          ViewBag.time=DateTime.Now;
           

            return View();
        }
        //采购订单显示表
        public IActionResult PurchaseShow()
        {
            return View();
        }
        //采购订单详情
        public IActionResult PurchaseDeit(int id)
        {
            ViewBag.pid = id;
            return View();
        }
        //入库
        public IActionResult RuKu()
        {
            return View();
        }
        //入库详细表
        public IActionResult RuKuDeit(int id)
        {
            ViewBag.time = DateTime.Now;
            ViewBag.rid = id;
            return View();
        }
        //库位详细表
        public IActionResult LocationWithShow(int id)
        {
            ViewBag.lid = id;
            return View();
        }
        //入库显示表
        public IActionResult RuKuShow() 
        {
            return View();
        }
        //开始入库
        public IActionResult BeginRuKu(int id) 
        {
            ViewBag.rdetid = id;
            return View();
        }
        //出库
        public IActionResult ChuKu(int id)
        {
            ViewBag.sid = id;
            ViewBag.time = DateTime.Now;
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
        public IActionResult EquipmentDeit(int id)
        {
            @ViewBag.EquipmentID = id;
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
        //仓库详情显示
        public IActionResult WarmHouseDeitShow(int id)
        {
            ViewBag.wid = id;
            return View();
        }
        //添加库位
        public IActionResult LocationAdd() 
        {
            return View();
        }
        //盘点显示
        public IActionResult CheckShow() 
        {
            return View();
        }
        //退货显示
        public IActionResult ReturnShow() 
        {
            return View();
        }
        //出库清单
        public IActionResult ChuKuList() 
        {
           
            return View();
        }
        //开始出库
        public IActionResult BeginChuKu(int id)
        {
            ViewBag.gid = id;
            return View();
        }
        //出库清单显示
        public IActionResult ChuKuListShow() 
        {
            return View();
        }
        //出库详情
        public IActionResult ChuKuDietShow(int id)
        {
            ViewBag.cid = id;
            return View();
        }


    }
}
