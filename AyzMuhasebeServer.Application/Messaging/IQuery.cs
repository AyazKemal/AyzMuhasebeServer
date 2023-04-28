using MediatR;

namespace AyzMuhasebeServer.Application.Messaging
{
    public interface IQuery<out TResponse>:IRequest<TResponse>
    {
    }
}
