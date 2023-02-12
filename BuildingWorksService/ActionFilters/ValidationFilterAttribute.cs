using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuildingWorksService.ActionFilters
{
    public class ValidationFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var action = context.RouteData.Values["action"];
            var controller = context.RouteData.Values["controller"];
            var arguments = context.ActionArguments.Select(x => x.Value.ToString());
            if (arguments == null)
            {
                context.Result = new BadRequestObjectResult($"Object is null. Controller {controller}, action: {action}");
                return;
            }
            //var param = context.ActionArguments.SingleOrDefault(x => x.Value.ToString().Contains(""));
        }
    }
}
