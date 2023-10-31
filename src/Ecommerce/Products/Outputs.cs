using Ecommerce.CommonClass;
using Ecommerce.ValueObjects;

namespace Ecommerce.Products;

/// <summary>
/// Representa un producto
/// </summary>
/// <param name="AccountId">Id de la cuenta</param>
/// <param name="Id">Id de producto</param>
/// <param name="Name">Nombre de producto</param>
/// <param name="IsActive">Indica si esta activo</param>
/// <param name="ShortDescription">Descripcion corta</param>
/// <param name="LargeDescription">Descripcion Larga</param>
/// <param name="Brand">Id de Marca</param>
/// <param name="Multimedias">Multimedias del producto, Imagenes, videos, etc</param>
/// <param name="DynamicFields">Datos dinamicos</param>
public record ProductOutput(string AccountId,
                            string Id,
                            string Name,
                            bool IsActive,
                            string? ShortDescription,
                            DescriptionVo LargeDescription,
                            string? Brand,
                            List<Multimedia> Multimedias,
                            List<DynamicFieldVo> DynamicFields);


