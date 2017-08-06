using System.Web.Mvc;

namespace UserManagementMVC.Controllers
{
    public class UploadController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Upload Page";

            return View();
        }

        public string Image()
        {
            return "Upload image";
        }

        public string File()
        {
            return "Upload File";
        }
    }
}