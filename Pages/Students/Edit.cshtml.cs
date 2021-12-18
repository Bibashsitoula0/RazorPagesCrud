using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesStudentContext _context;

        public EditModel(RazorPagesStudentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student{ get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Student = await _context.Students.FindAsync(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Student student)
        {
            
               //_context.Attach(Student).State = EntityState.Modified;
            var inDb = await _context.Students.FindAsync(student.Id);
            inDb.Name=student.Name;
            inDb.Address=student.Address;
           
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
