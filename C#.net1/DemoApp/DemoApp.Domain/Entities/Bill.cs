﻿using DemoApp.Domain.Abstractions;
using DemoApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Domain.Entities
{
	[Table("Bills")]
	public class Bill : BaseEntity<Guid>
	{
		[Column(TypeName = "nvarchar(1000)")]
		public string FirstName { get; set; } = string.Empty;

		[Column(TypeName = "nvarchar(1000)")]
		public string LastName { get; set; }

		[Column(TypeName = "nvarchar(1000)")]
		public string Email { get; set; }

		[Column(TypeName = "nvarchar(1000)")]
		public string Address { get; set; } = string.Empty;

		[Column(TypeName = "nvarchar(1000)")]
		public string Telephone { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal TotalAmount { get; set; }
		public PaymentMethod PaymentMethod { get; set; }

		public ICollection<BillDetail> BillDetails { get; set; }
	} 
}
