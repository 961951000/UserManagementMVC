using System.Web.Mvc;

namespace UserManagementMVC.Controllers
{
    [RoutePrefix("Permission")]
    [Route("{action=Index}/{id?}")]
    public class PermissionController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Permission Page";

            return View();
        }

        [Route("Tenants/{TenantId}/Add")]
        public string Add(int tenantId)
        {
            return "Add individual user for a specified tenant";
        }

        [Route("Tenants/{TenantId}/Users/{UserId}")]
        public string Users(int tenantId, int userId)
        {
            return "Remove individual user for a specified tenant";
        }

    }
}