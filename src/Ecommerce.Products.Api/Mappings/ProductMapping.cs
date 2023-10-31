using AutoMapper;
using Ecommerce.CommonClass;
using Ecommerce.Products;

namespace Ecommcerce.Web.Admin.Mappings;

public class ProductMapping : Profile
{
    public ProductMapping()
    {
        CreateMap<Product, ProductOutput>();

        CreateMap<Pagination<Product>, Pagination<ProductOutput>>();
    }
}
