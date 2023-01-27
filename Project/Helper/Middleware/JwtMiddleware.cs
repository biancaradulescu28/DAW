using Project.Helper.JwtUtils;
using Project.Services.UserService;

namespace Project.Helper.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IUserService userService, IJwtUtils jwtUtils)
        {
            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            var userId = jwtUtils.ValidateJwtToken(token);
            if (userId != Guid.Empty)
            {
                httpContext.Items["User"] = userService.GetById(userId);

            }

            await _next(httpContext);
        }
    }
}
