using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Presentation.Filters
{
    public class ExceptionHandlingFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // Log exception here if necessary
            context.Result = new ObjectResult(new { error = context.Exception.Message })
            {
                StatusCode = 500
            };
            context.ExceptionHandled = true;
        }
    }
}