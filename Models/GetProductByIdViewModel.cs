using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExample.Models
{
	public class GetProductByIdViewModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
	}
}
