namespace pj1
{
    internal class TemplateMiddleware
    {
        private readonly RequestDelegate _next;
        public TemplateMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            //Definir a logica antes;

            //Chama o próximo middleware no pipeline
            await _next(httpContext);

            // Definir a logica depois
        }
    }
}