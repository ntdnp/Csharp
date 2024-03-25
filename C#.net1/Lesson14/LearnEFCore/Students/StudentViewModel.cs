using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Studens
{
    public class StudentViewModel
    {
        public Guid Id { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Guid MajorId { get; set; }
        public string  StatusStudent { get; set; }

    }
}
