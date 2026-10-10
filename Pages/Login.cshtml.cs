using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
namespace MyPortfolioASP.Pages;
[AllowAnonymous]
public class LoginModel : PageModel
{
    [BindProperty]
    public string Password { get; set; } = string.Empty;
[BindProperty(SupportsGet = true)]
public string? ReturnUrl { get; set; }

public async Task<IActionResult> OnPostAsync()
{
    if (Password != "Muhd")
    {
        ModelState.AddModelError(
            string.Empty, "Wrong password. Please try again.");

        return Page();
    }

    var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, "Admin")
    };

    var identity = new ClaimsIdentity(
        claims,
        CookieAuthenticationDefaults.AuthenticationScheme);

    var principal = new ClaimsPrincipal(identity);

    await HttpContext.SignInAsync(
        CookieAuthenticationDefaults.AuthenticationScheme,
        principal);

    if (!string.IsNullOrEmpty(ReturnUrl) &&
        Url.IsLocalUrl(ReturnUrl))
    {
        return LocalRedirect(ReturnUrl);
    }

    return RedirectToPage("/Index", new { area = "Admin" });
}
}