using System.Web.Mvc;

namespace UserManagementMVC.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Register Page";

            return View();
        }

        public new string User()
        {
            return "User register by user info";
        }

        public string Tenant()
        {
            return "Tenant register by tenant info";
        }
    }
}