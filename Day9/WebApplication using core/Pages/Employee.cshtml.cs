using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication_using_core.Models;

namespace WebApplication_using_core.Pages
{
    public class EmployeeModel : PageModel
    {
        [BindProperty]
        public Employee emps { get; set; } = new Employee();
        public void OnGet()
        {
            //this method get called when page loaded
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //creating viewData
            ViewData["message"] = $"hello {emps.Name}";
            return Page();
        }
    }
}
