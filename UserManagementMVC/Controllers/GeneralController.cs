using System.Web.Mvc;

namespace UserManagementMVC.Controllers
{
    [RoutePrefix("General")]
    public class GeneralController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "General Page";

            return View();
        }

        [Route("User/{UserId}")]
        public new string User(int userId)
        {
            return "Get specified user info";
        }

        public string Users(int top, int skip)
        {
            return "Get the numbers of user list from {skip}";
        }

        [Route("Tenant/{TenantId}")]
        public string Tenant(int tenantId)
        {
            return "Get specified tenant info";
        }

        public string Tenants(int top, int skip)
        {
            return "Get the numbers of tenant list from {skip}";
        }

        [Route("Users/{UserId}/Emails/{Email}")]
        public string Emails(int userId, int email)
        {
            return "Activating the user by email with guid provided";
        }
    }
}