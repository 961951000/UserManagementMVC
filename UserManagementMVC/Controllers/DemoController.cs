using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using UserManagementMVC.Helper;
using UserManagementMVC.Models;

namespace UserManagementMVC.Controllers
{
    public class DemoController : Controller
    {
        public JsonResult Index()
        {
            Logger.Debug($"Start --- {DateTime.Now}");
            ViewBag.Title = "Demo Page";
            var result = new Result<User>
            {
                StatusCode = 200,
                Data = new[]
                {
                    new User
                    {
                        UserId = DateTime.Now.Second,
                        Account = "caixiangwei@beyondsoft.com",
                        Password = "This is a secret",
                        UserName = "Xiangwei"
                    }
                }
            };
            Logger.Debug($"End --- {DateTime.Now}");

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}