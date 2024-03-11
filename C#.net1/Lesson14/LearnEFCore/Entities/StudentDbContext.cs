using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEFCore.Entities
{
    public class StudentDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet <Major>Majors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NTD-NP\\SQLEXPRESS;Database=StudentDb;User Id=sa;Password=12345;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        }

    }
}
