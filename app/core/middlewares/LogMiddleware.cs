using System.Threading.Tasks;
using CustomerManagement.app.core.models;
using CustomerManagement.app.core.services;
using CustomerManagement.app.core.services.models;
using Microsoft.AspNetCore.Http;

namespace CustomerManagement.app.core.middlewares
{
    public class LogMiddleware
    {
        private readonly RequestDelegate _next;
        public LogMiddleware(RequestDelegate _next)
        {
            this._next = _next;

        }
        public async Task Invoke(HttpContext context, LogService logService)
        {

            await logService.Save(new LogDTO()
            {
                Method = context.Request.Method,
                Query = context.Request.QueryString.ToString(),
                IpAddress = context.Connection.RemoteIpAddress.ToString(),
            });
            await _next(context);


        }
    }
}