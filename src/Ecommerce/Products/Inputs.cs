using Ecommerce.CommonClass;
using Ecommerce.ValueObjects;

namespace Ecommerce.Products;

public record UpdateProductInput(string? ProductId,
                                 string? Name,
                                 bool? IsActive,
                                 string? ShortDescription,
                                 DescriptionVo? LargeDescription,
                                 string? Brand,
                                 List<DynamicFieldVo>? DynamicFields);


