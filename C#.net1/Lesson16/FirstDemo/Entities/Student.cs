﻿using FirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Entities
{
    [Table("Students")]
    public class Student : BaseEntity
    {
        [Column(TypeName = "nvarchar(1000)")]
        public string StudentName { get; set; }
       
        public int Age { get; set; }
        [Column(TypeName = "nvarchar(1000)")]

        public string Address { get; set; }
        public Guid MajorId { get; set; }

        [ForeignKey(nameof(MajorId))]
        public Major Major { get; set; }

    }
}