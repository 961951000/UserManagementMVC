using System.Web.Mvc;

namespace UserManagementMVC.Controllers
{
    [RoutePrefix("status_code")]
    [Route("{action=Index}/{id?}")]
    public class StatusCodeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "status_code Page";

            return View();
        }

        public string Emails()
        {
            return "Generate a active email to user";
        }

        [Route("Users/{UserId}/Info")]
        public string Info(int userId)
        {
            return "Update user info, like profile";
        }

        [Route("Users/{UserId}/Password")]
        public string Password(int userId)
        {
            return "Update user password";
        }
    }
}