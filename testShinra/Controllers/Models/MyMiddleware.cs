using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testShinra.Controllers.Models
{
    public class MyMiddleware
    {
         private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public MyMiddleware(RequestDelegate next, ILoggerFactory logFactory)
    {
        _next = next;

        _logger = logFactory.CreateLogger("MyMiddleware");
    }

    public async Task Invoke(HttpContext httpContext)
    {
        _logger.LogInformation("MyMiddleware executing..");

        await _next(httpContext); // calling next middleware

    }
    }
}