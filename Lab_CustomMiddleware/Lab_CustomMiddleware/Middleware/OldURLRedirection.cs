using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Lab_CustomMiddleware.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class OldURLRedirection
    {
        private readonly RequestDelegate next;

        public OldURLRedirection(RequestDelegate _next)
        {
            next = _next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var url = context.Request.Path.Value;
            string rediretUrl = "";
            if(!string.IsNullOrEmpty(url))
            {
                url = url.ToLowerInvariant();
            }
            switch (url)
            {
                case "/home/privacy":
                    rediretUrl = "/privacy/policy";
                    break;
                case "account/login":
                    rediretUrl = "login";
                    break;
;            }

            if(!string.IsNullOrEmpty(rediretUrl))
            {
                context.Response.Redirect(rediretUrl);
                return;
            }
            //call the next middleware in pipeline
            await next(context);
        }

        //public Task Invoke(HttpContext httpContext)
        //{

        //    return next(httpContext);
        //}
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class OldURLRedirectionExtensions
    {
        public static IApplicationBuilder UseOldURLRedirection(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<OldURLRedirection>();
        }
    }
}
