using Microsoft.EntityFrameworkCore;
using student_app.Models;

namespace student_app.DAL
{
    public class StudentDBcontext : DbContext
    {
        public StudentDBcontext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students {  get; set; }
    }
}
