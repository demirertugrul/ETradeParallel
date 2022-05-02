using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ETradeParallel.Infrastructure.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Where(x => x.Value.Errors.Any())
                    .ToDictionary(k => k.Value, v => v.Value.Errors.Select(e => e.ErrorMessage))
                    .ToArray();
                context.Result = new BadRequestObjectResult(errors);
                return; 
            }
            await next();
        }
    }
}
