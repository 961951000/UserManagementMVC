using System.Web.Mvc;

namespace UserManagementMVC.Controllers
{
    [RoutePrefix("Privilege")]
    public class PrivilegeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Privilege Page";

            return View();
        }

        [Route("Users/{UserId}")]
        public string Users(int userId)
        {
            return "Remove individual user by user id";
        }

        [Route("Users/Active")]
        public string Active()
        {
            return "Active individual user by user id";
        }

        [Route("Users/Deactive")]
        public string Deactive()
        {
            return "Deactive individual user by user id";
        }
    }
}