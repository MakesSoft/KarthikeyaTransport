using Microsoft.AspNetCore.Mvc;

namespace MyAccountProject.Controllers
{
    public class ListFooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}