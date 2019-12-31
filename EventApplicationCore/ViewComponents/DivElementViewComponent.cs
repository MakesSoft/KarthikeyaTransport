using Microsoft.AspNetCore.Mvc;

namespace MyAccountProject.Controllers
{
    public class DivElementViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}