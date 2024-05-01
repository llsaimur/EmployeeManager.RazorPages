using EmployeeManager.RazorPages.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManager.RazorPages.Pages.Security
{
    [Authorize]

    public class SignOutModel : PageModel
    {
        private readonly SignInManager<AppIdentityUser> signinManager;
        public SignOutModel(SignInManager<AppIdentityUser> signinManager)
        {
            this.signinManager = signinManager;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await signinManager.SignOutAsync();
            return RedirectToPage("/Security/SignIn");
        }
        public void OnGet()
        {
        }
    }
}
