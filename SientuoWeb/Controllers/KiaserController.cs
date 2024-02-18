using Autofac;
using Microsoft.AspNetCore.Mvc;
using SientuoComm.Helper;
using SientuoInterFace;
using SientuoService;
using System.ComponentModel;
using System.Reflection;

namespace SientuoWeb.Controllers
{
    public class KiaserController: Controller
    {
        private readonly IManData _manData;
        private readonly IPerson _person;
        public KiaserController(IManData manData, IPerson person) 
        {
            _manData = manData;
            _person = person;
        }



        public IActionResult Index()
        {

            ViewData["Kiaser2"] = _person.IsDrink();
            TempData["Kiaser3"] = "我是王五";
            object Kiaser4 = "我是哈哈哈";

           

            ViewBag.Kiaser1 = _manData.GetName();
            LogHelper.WriteInfo("这是我的第一个core日志");

            return View(Kiaser4);
        }
    }
}
