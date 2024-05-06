using MediatR;

namespace BuildingBlocks.CQRS;

// return something
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}

// return void
public interface ICommand : ICommand<Unit>
{
}
