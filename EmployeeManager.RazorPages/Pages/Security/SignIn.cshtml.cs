using EmployeeManager.RazorPages.Models;
using EmployeeManager.RazorPages.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManager.RazorPages.Pages.Security
{
    public class SignInModel : PageModel
    {
        [BindProperty]
        public SignIn SignInData { get; set; }
        private readonly SignInManager<AppIdentityUser> signinManager;
        public SignInModel(SignInManager<AppIdentityUser> signinManager)
        {
            this.signinManager = signinManager;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var result = await signinManager.PasswordSignInAsync
                (SignInData.UserName, SignInData.Password,
                SignInData.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToPage("/EmployeeManager/List");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login!");
                }
            }
            return Page();
        }

        public void OnGet()
        {
        }
    }
}
