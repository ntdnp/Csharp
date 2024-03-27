using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Entities
{
    public class StudentDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet <Major>Majors { get; set; }


        public StudentDbContext(DbContextOptions<StudentDbContext> options) 
            : base(options)
        {
        
        }
    }
}
