using Microsoft.AspNetCore.Mvc;
using MyAccountProject.Model;

namespace MyMVC.Controllers
{
    public class MenuMasterController : Controller
    {
        private DatabaseContext _context;

        public MenuMasterController(DatabaseContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var menuMasters = _context.MenuMaster;

            return PartialView(menuMasters);
        }
    }
}