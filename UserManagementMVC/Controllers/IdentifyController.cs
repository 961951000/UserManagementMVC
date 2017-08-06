using System.Web.Mvc;

namespace UserManagementMVC.Controllers
{
    [RoutePrefix("Identify")]
    public class IdentifyController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Identify Page";

            return View();
        }

        [Route("Users/{UserId}/Tokens")]
        public string Tokens(int userId)
        {
            return "Binding token for user's service, like wps, adobe, office365, etc.";
        }

        [Route("Users/{UserId}/Bindings")]
        public string Bindings(int userId)
        {
            return "Binding token for user's service, like wechat, alipay, etc.";
        }
    }
}