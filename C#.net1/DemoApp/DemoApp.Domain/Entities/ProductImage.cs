using DemoApp.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Domain.Entities
{
	[Table("ProductImages")]
	public class ProductImage : BaseEntity<Guid>
	{
		[Column(TypeName = "ntext")]
		public string ImageLink { get; set; }

		[Column(TypeName = "ntext")]
		public string? Alt { get; set; }

		public Guid ProductId { get; set; }

		[ForeignKey(nameof(ProductId))]
		public Product Product { get; set; }
	}
}
