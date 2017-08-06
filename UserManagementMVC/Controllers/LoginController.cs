using System.Web.Mvc;

namespace UserManagementMVC.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Login Page";

            return View();
        }

        public new string User()
        {
            return "User login by password";
        }

        public string Tenant()
        {
            return "Tenant login by password";
        }
    }
}