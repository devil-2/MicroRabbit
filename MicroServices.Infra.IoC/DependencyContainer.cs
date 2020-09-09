using MicroServices.Domain.Core.Bus;
using MicroServices.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServices.Infra.IoC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			services.AddTransient<IEventBus, RabbitMQBus>();

		}
	}
}
