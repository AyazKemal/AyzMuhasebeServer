using MediatR;

namespace AyzMuhasebeServer.Application.Messaging
{
    public interface ICommand<out TResponse>: IRequest<TResponse>
    {
    }
}
