using MediatR;
using MediatRExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRExample.Med.Queries
{
	//Sorgu calistirildiginda geriye dondurulecek sinif tipi tanimlaniyor.
	public class GetProductByIdQuery :IRequest<GetProductByIdViewModel>
	{
		//Querynin calistirilmasi icin gereken parametreler tanimlaniyor.
		public Guid Id { get; set; }
	}
}
