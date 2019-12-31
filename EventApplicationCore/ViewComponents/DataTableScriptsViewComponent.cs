using Microsoft.AspNetCore.Mvc;

namespace MyAccountProject.Controllers
{
    public class DataTableScriptsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}