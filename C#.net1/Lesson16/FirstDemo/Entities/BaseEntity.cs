using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstDemo.Entities
{
    public abstract class BaseEntity<TKey>
    {
        [Key]
        public Guid Id { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
