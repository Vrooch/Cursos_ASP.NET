using System.Diagnostics;
using Serilog;

namespace pj1
{
    internal class MeuMiddleware
    {
        private readonly RequestDelegate _next;
        public MeuMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            // Logica antes
            var sw = Stopwatch.StartNew();

            // Proximo
            await _next(httpContext);

            // Logica depois
            sw.Stop();

            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Information($"A execução demorou {sw.Elapsed.TotalMicroseconds}ms ({sw.Elapsed.TotalSeconds} segundos)");

        }
    }
}

