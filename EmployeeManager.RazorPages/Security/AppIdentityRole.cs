using Microsoft.AspNetCore.Identity;

namespace EmployeeManager.RazorPages.Security
{
    public class AppIdentityRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
