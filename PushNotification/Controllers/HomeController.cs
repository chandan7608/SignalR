using PushNotification.Models;
using PushNotification.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PushNotification.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetTopHeader()
        {
            return PartialView("_TopHeader");
        }


        [HttpPost]
        public JsonResult Register(RegisterViewModel model)
        {
            RegisterRepository obj = new RegisterRepository();
            obj.SaveRegistration(model.UserName, model.Password);

            return Json(new { Message = "Data hase been saved" }, JsonRequestBehavior.AllowGet);
        }

    }
}