using Microsoft.AspNetCore.Mvc;
using MyAccountProject.Model;
using System.Linq;

namespace MyAccountProject.Controllers
{
    public class MenuMasterViewComponent : ViewComponent
    {
        private DatabaseContext _context;

        public MenuMasterViewComponent(DatabaseContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var menuMasters = _context.MenuMaster.ToList();

            return View(menuMasters);
        }
    }
}