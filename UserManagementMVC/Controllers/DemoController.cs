using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using UserManagementMVC.DatabaseContext;
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

        private int Add(User user)
        {
            using (var db = new AzureContext())
            {
                db.User.Add(user);
                return db.SaveChanges();
            }
        }

        private int Delete(int userId)
        {
            using (var db = new AzureContext())
            {
                var user = Select(userId);
                if (user != null)
                {
                    db.User.Remove(user);
                }
                return db.SaveChanges();
            }
        }

        private int Update(User user)
        {
            using (var db = new AzureContext())
            {
                db.User.Attach(user);
                return db.SaveChanges();
            }
        }

        private User Select(int userId)
        {
            using (var db = new AzureContext())
            {
                return db.User.FirstOrDefault(x => x.UserId == userId);
            }
        }
    }
}