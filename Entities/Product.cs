﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExample.Entities
{
	public class Product
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
		public decimal Amount { get; set; }
	}
}
