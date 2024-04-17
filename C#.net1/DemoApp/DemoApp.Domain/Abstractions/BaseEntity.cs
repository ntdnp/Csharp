using DemoApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Domain.Abstractions
{
	public abstract class BaseEntity<Tkey>
	{
		[Key]
		public Tkey Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public EntityStatus Status { get; set; }

	}
}
