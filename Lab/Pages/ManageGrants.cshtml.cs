using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab.Pages
{
    public class Grant
    {
        public string GrantName { get; set; }
        public string Agency { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public decimal AwardAmount { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime AwardDate { get; set; }
        public List<string> AssociatedPeople { get; set; }
    }
    public class ManageGrantsModel : PageModel
    {
        [BindProperty]
        public Grant Grant { get; set; }

        public List<string> Agencies { get; set; } = new List<string> { "Agency1", "Agency2", "Agency3" };
        public List<string> People { get; set; } = new List<string> { "Person1", "Person2", "Person3" };
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Handle the form submission logic here

            return RedirectToPage("Success");
        }
    }
}
