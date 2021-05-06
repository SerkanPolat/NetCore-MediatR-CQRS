﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Med.Commands
{
	public class CreateProductCommand : IRequest<Guid>
	{
		public string Name { get; set; }
		public int Quantity { get; set; }
		public decimal Value { get; set; }
		public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
		{
			public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
			{

				return Task.FromResult(Guid.NewGuid());
				
				//Repository ile veritabanina kayit yazilacak. Veya EventBus tetiklenebilir
			}
		}
	}
}
