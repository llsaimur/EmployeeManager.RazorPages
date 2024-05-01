using EmployeeManager.RazorPages.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManager.RazorPages.Pages.EmployeeManager
{
    [Authorize(Roles = "Manager")]
    public class ListModel : PageModel
    {
        private readonly AppDbContext db = null;
        public List<Employee> Employees { get; set; }
        public ListModel(AppDbContext db)
        {
            this.db = db;
        }
        public void OnGet()
        {
            this.Employees = (from e in db.Employees orderby e.EmployeeId select e).ToList();
        }
    }
}
