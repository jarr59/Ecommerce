using AutoMapper;
using Ecommerce.CommonClass;
using Ecommerce.Products.Commands;
using Ecommerce.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Ecommerce.Products.Api.Controllers
{
    [ApiController]
    [Route("api/accounts/{accountId}/products")]
    public class ProductController : ControllerBase
    {
        readonly IMediator _mediator;
        readonly IMapper _mapper;

        public ProductController(IMediator mediator,
                                 IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Devuelve un listado de productos paginados
        /// </summary>
        /// <param name="accountId">Ids de cuenta</param>
        /// <param name="productIds">Ids de productos</param>
        /// <param name="name">Nombre, letra o palabra en el nombre del producto</param>
        /// <param name="isActive">Activo o inactivo</param>
        /// <param name="brands">Ids de marcas</param>
        /// <param name="page">Pagina</param>
        /// <param name="itemsPerPage">Items por pagina</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetProducts([FromRoute] string accountId, [FromQuery] List<string>? productIds,
                                                     [FromQuery] string? name, [FromQuery] bool? isActive, 
                                                     [FromQuery] List<string>? brands, [FromQuery] int page = 1, 
                                                     [FromQuery] int itemsPerPage = 15)
        {
            GetProductsPaginated query = new(AccountId: accountId,
                                             ProductIds: productIds,
                                             Name: name,
                                             IsActive: isActive,
                                             Brands: brands,
                                             Page: page,
                                             ItemsPerPage: itemsPerPage);

            Pagination<ProductOutput> products = _mapper.Map<Pagination<ProductOutput>>(await _mediator.Send(query));

            return Ok(products);
        }

        /// <summary>
        /// Actualiza o crea un listado de productos
        /// </summary>
        /// <param name="accountId">Id de cuenta</param>
        /// <param name="input">Lista de productos a actualizar</param>
        /// <returns></returns>
        [HttpPatch]
        public async Task<IActionResult> PatchProducts([FromRoute] string accountId,
                                                       [FromBody] List<UpdateProductInput> input)
        {
            UpdateProduct command = new(input, accountId);

            List<Product> restul = await _mediator.Send(command);

            return Ok(restul);
        }
    }
}
