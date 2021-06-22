using System.Threading.Tasks;
using CustomerManagement.app.core.services;
using CustomerManagement.app.core.services.models;
using Microsoft.AspNetCore.Http;

namespace CustomerManagement.app.core.middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate _next)
        {
            this._next = _next;

        }
        public async Task Invoke(HttpContext context, AppExceptionService appExcepitonService)
        {
            try
            {
                await _next(context);
            }
            catch (System.Exception e)
            {
                await appExcepitonService.Save(new AppExceptionDTO()
                {
                    Message = e.Message,
                    Method = context.Request.Method,
                    StackTrace = e.StackTrace,
                    InnerException = e.InnerException.StackTrace,
                    Source = e.Source,
                    TargetSite = e.TargetSite.Name
                });

                context.Response.StatusCode = 500;
                await context.Response.WriteAsync(e.Message);
                await context.Response.StartAsync();
            }
        }
    }
}