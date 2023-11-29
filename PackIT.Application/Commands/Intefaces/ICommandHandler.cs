﻿namespace PackIT.Application.Common.Intefaces
{
	public interface ICommandHandler<TCommand>
		where TCommand : class, ICommand
	{
		Task HandleAsync(TCommand command);
	}
}
