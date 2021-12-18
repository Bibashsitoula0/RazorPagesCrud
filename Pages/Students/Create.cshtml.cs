using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using RazorPages.Data;
using RazorPages.Models;


namespace RazorPages.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesStudentContext context;

        public CreateModel(RazorPages.Data.RazorPagesStudentContext context)
        {
            this.context = context;
        }

      

        public IActionResult OnGet()
        {
            return Page();

        }

            [BindProperty]

            public Student Students { get; set; }

           public async Task<IActionResult> OnPostAsync(Student Students)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            context.Students.Add (Students);
            await context.SaveChangesAsync();
             return RedirectToPage("./Index");
        }
    }
}
