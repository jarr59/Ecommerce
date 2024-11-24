using MediatR;

namespace Ecommerce.Store.Effects
{
    public interface ICustomRequest<out TResponse> : IRequest<TResponse> {}
}
