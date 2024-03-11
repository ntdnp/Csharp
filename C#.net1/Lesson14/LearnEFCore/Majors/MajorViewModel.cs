using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEFCore.Majors
{
    public class MajorViewModel
    {
        public Guid Id { get; set; }
        public string MajorName { get; set; }
        public string StatusName { get; set;}
    }
}
