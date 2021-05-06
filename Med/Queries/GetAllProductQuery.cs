using MediatR;
using MediatRExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Med.Queries
{
	public class GetAllProductQuery : IRequest<List<GetProductByIdViewModel>>
	{
		public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductByIdViewModel>>
		{
			public Task<List<GetProductByIdViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
			{
				var model = new GetProductByIdViewModel()
				{
					Id = Guid.NewGuid(),
					Name = "Monitor"
				};
				var model2 = new GetProductByIdViewModel()
				{
					Id = Guid.NewGuid(),
					Name = "Kalem"
				};
				return Task.FromResult(new List<GetProductByIdViewModel>() { model,model2 });
			}
		}
	}
}