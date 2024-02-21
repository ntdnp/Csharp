using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP3
{
    internal interface IHasStatus
    {
        public  Status Status { get; set; }
    }
    public enum Status 
    {
        Active =1,
        Inactive =2,
    }

}
