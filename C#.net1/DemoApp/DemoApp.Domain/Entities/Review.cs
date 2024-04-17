using DemoApp.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Domain.Entities
{
	[Table("Reviews")]
	public class Review : BaseEntity<Guid>
	{

		[Column(TypeName = "nvarchar(1000)")]
		public string ReviewerName { get; set; }

		[Column(TypeName = "nvarchar(1000)")]
		public string? Email { get; set; }

		[Column(TypeName = "ntext")]
		public string Content { get; set; }
		public int Rating { get; set; }


		public Guid ProductId { get; set; }

		[ForeignKey(nameof(ProductId))]
		public Product Product { get; set; }

	}
}
