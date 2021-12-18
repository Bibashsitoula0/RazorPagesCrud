using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Data
{
    public class RazorPagesStudentContext : DbContext
    {
        public RazorPagesStudentContext(DbContextOptions<RazorPagesStudentContext> options): base(options)
        {
            
        }
        public DbSet<Student> Students{get;set;}

        
    }
}