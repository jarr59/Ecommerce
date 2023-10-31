using Ecommerce.CommonClass;
using Ecommerce.Products.Interfaces;
using Ecommerce.Products.Queries;
using MediatR;

namespace Ecommerce.Products.Handlers.Queries;

class GetProductsPaginatedHandler : IRequestHandler<GetProductsPaginated, Pagination<Product>>
{
    readonly IProductRepo _productRepo;

    public GetProductsPaginatedHandler(IProductRepo productRepo)
    {
        _productRepo = productRepo;
    }

    public async Task<Pagination<Product>> Handle(GetProductsPaginated request, CancellationToken cancellationToken)
    {
        return await _productRepo.GetPagination(request.AccountId,
                                                request.ProductIds ?? new(),
                                                request.Name,
                                                request.IsActive,
                                                request.Brands ?? new(),
                                                request.Page,
                                                request.ItemsPerPage);
    }
}
