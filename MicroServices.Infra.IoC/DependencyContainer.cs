using MicroServices.Domain.Core.Bus;
using MicroServices.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroServices.Infra.IoC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			//Domain Bus
			services.AddTransient<IEventBus, RabbitMQBus>();
		}
	}
}
