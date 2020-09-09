using MicroServices.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroServices.Domain.Core.Bus
{
	public interface IEventHandler<in TEvent>:IEventHandler where TEvent : Event
	{
		Task Handle(TEvent @event);
	}

	public interface IEventHandler { }
}