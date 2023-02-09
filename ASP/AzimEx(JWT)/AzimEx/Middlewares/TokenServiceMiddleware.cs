using AzimEx.Services.Tokens;
using System.Net;

namespace AzimEx.Middlewares
{
    public class TokenServiceMiddleware : IMiddleware
    {
            private readonly ITokenService _tokenService;

            public TokenServiceMiddleware(ITokenService tokenService)
            {
                _tokenService= tokenService;
            }

            public async Task InvokeAsync(HttpContext? context, RequestDelegate? next)
            {
                if (await _tokenService.IsCurrentActiveToken())
                {
                    await next!.Invoke(context!);
                    return;
                }
                context!.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
        }
    }
}
