using MediatR;
using MicroServices.Banking.Domain.Commands;
using MicroServices.Banking.Domain.Events;
using MicroServices.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServices.Banking.Domain.CommandHandlers
{
	public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
	{
		private readonly IEventBus _bus;

		public TransferCommandHandler(IEventBus bus)
		{
			_bus = bus;
		}

		public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
		{
			//publish event to rabbitMQ 

			_bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
			return Task.FromResult(true);
		}
	}
}
