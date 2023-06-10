using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Library.Attributes
{
    public class AuthorizeAccessAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            return;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var contextId = context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "id").Value;
            var id = context.HttpContext.Request.Query["id"].ToString();

            if (contextId != id)
            {
                context.Result = new RedirectResult("/Account/AccessDenied");
            }
        }
    }
}
