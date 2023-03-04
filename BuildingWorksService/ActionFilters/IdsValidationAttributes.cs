using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuildingWorksService.ActionFilters
{
    public class IdsValidationAttributes : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var action = context.RouteData.Values["action"];
            var controller = context.RouteData.Values["controller"];
            var arguments = context.ActionArguments;
            if (arguments["id"] == null || Convert.ToInt32(arguments["id"]) <= 0)
            {
                context.Result = new BadRequestObjectResult($"Object is null. Controller {controller}, action: {action}");
                return;
            }
        }
    }
}