using Microsoft.AspNetCore.Mvc;
using MyAccountProject.Filters;

namespace MyAccountProject.Controllers
{
    [ValidateAdminSession]
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}