using MicroServices.Domain.Core.Events;
using System;

namespace MicroServices.Domain.Core.Commands
{
	public abstract class Command:Message
	{
		public DateTime TimeStamp { get; protected set; }

		protected Command()
		{
			TimeStamp = DateTime.Now;
		}
	}
}
