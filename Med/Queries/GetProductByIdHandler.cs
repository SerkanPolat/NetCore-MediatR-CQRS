using MediatR;
using MediatRExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Med.Queries
{

	public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdViewModel>
	{
		public Task<GetProductByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
		{
			var viewModel = new GetProductByIdViewModel()
			{
				Id=Guid.NewGuid(),
				Name="Book"
			};
			return Task.FromResult(viewModel);

			//Get Product From Repository
		}
	}
}
