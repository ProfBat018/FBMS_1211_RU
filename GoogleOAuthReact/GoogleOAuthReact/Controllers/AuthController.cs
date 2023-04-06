using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GoogleOAuthReact.Controllers;

public class AuthController : Controller
{

    public SignInManager<User> signInManager = new();
    // GET
    [HttpPost]
    [AllowAnonymous]
    [Route("account/external-login")]
    public IActionResult ExternalLogin(string provider, string returnUrl)
    {
        var redirectUrl = $"https://api.domain.com/identity/v1/account/external-auth-callback?returnUrl={returnUrl}";
        var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
        properties.AllowRefresh = true;
        return Challenge(properties, provider);
    }
}

public class User
{
}