using Laba1.Middleware;

namespace Laba1.Extensions
{
    public static class appExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app) => app.UseMiddleware<LogMiddleware>();
    }
}
