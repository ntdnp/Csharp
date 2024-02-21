using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP3
{
    public class Category: IHasDateTime, IHasStatus,ICommonService
    {
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Status Status { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime UpdataDate { get; set; }

        public string GetInfor()
        {
            return $"{Name}, {CreateDate}";
        }
    }
}
