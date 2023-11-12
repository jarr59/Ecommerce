using Ecommerce.CommonClass;
using Ecommerce.Enums;
using Ecommerce.ValueObjects;

namespace Ecommerce.Products;

public record UpdateProductInput(string? ProductId,
                                 string? Name,
                                 ProductState ProductState,
                                 string? ShortDescription,
                                 DescriptionVo? LargeDescription,
                                 string? Brand,
                                 List<DynamicFieldVo>? DynamicFields);


