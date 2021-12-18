using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Pages.Students
{
   public class DeleteModel :PageModel
   {
        private readonly RazorPagesStudentContext context;

        public DeleteModel(RazorPages.Data.RazorPagesStudentContext context)
       {
            this.context = context;
        }
       [BindProperty]
         public Student Student{ get; set; }

         public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await context.Students.FindAsync(id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
         public async Task<IActionResult> OnPostAsync(int id)
        {
            Student = await context.Students.FindAsync(id);
           
            context.Students.Remove(Student);
            await context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
        


      
    }
    
}