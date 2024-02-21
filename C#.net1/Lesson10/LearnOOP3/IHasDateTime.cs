using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP3
{
    internal interface IHasDateTime
    {
         public DateTime CreateDate { get; set; }
         public DateTime UpdataDate { get; set; }

    }
}
