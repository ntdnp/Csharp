using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEFCore.Majors
{
    public class UpdateMajorViewModel
    {
        public Guid Id { get; set; }
        public string MajorName { get; set; }
        public EntityStatus Status { get; set; }
    }
}
