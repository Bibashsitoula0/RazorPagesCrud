using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesStudentContext context;

        public IndexModel(RazorPages.Data.RazorPagesStudentContext context)
        {
            this.context = context;
        }

        public IEnumerable<Student> Students { get; set; }

        public  void OnGet()
        {
         Students =  context.Students;
         
        }
    }
}
