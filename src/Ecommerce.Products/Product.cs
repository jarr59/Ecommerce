using EcommerceKernel.CommonClass;
using EcommerceKernel.ValueObjects;

namespace Ecommerce.Products;

public class Product
{
    /// <summary>
    /// For entityfamework
    /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    protected Product() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public Product(string accountId,
                   string id,
                   string name,
                   string? description,
                   DescriptionVo largeDescription,
                   string? brand,
                   List<DynamicFieldVo> dynamicFields)
    {
        AccountId = accountId;
        
        Id = id;
        
        Name = name;
        
        ShortDescription = description;
        
        LargeDescription = largeDescription;
        
        Brand = brand;

        if (Multimedias == null || Multimedias.Count == 0)
            Multimedias = new();

        DynamicFields = dynamicFields;
    }

    /// <summary>
    /// Id de cuenta
    /// </summary>
    public string AccountId { get; set; }

    /// <summary>
    /// Id de producto
    /// </summary>
    public string Id { get; private set; }

    /// <summary>
    /// Nombre del producto
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Indica si el producto esta activo
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Descripcion corta del producto
    /// </summary>
    public string? ShortDescription { get; set; }

    /// <summary>
    /// Descripcion larga del producto
    /// </summary>
    public DescriptionVo LargeDescription { get; set; }

    /// <summary>
    /// Marca del producto
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    /// Multimedia del producto
    /// </summary>
    public List<Multimedia> Multimedias { get; set; }

    /// <summary>
    /// Datos dinamicos del producto
    /// </summary>
    public List<DynamicFieldVo> DynamicFields { get; set; }
}
