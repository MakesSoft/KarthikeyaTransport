using Microsoft.AspNetCore.Mvc.Filters;

namespace MyAccountProject.Filters
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        //public override void OnException(ExceptionContext context)
        //{
        //    context.Result = new RedirectResult("/Error/Error");
        //}
    }
}