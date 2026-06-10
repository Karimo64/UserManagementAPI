namespace UserManagementAPI.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Let Swagger through without token
            if (context.Request.Path.StartsWithSegments("/swagger") ||
                context.Request.Path.StartsWithSegments("/api"))
            {
                await _next(context);
                return;
            }

            var token = context.Request.Headers["Authorization"].FirstOrDefault();
            if (token != "Bearer mysecrettoken")
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsJsonAsync(new { error = "Unauthorized" });
                return;
            }

            await _next(context);
        }
    }
}