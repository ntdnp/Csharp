using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Studens
{
    public class CreateStudentViewModel
    {
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Guid MajorId { get; set; }
    }
}