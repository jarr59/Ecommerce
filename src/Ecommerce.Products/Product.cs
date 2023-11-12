using Ecommerce.CommonClass;
using Ecommerce.Enums;
using Ecommerce.ValueObjects;

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
                   string? id,
                   string name)
    {
        AccountId = accountId;

        Id = id ?? Guid.NewGuid().ToString();

        Name = name;

        Multimedias ??= new();

        DynamicFields ??= new();
    }

    /// <summary>
    /// Id de cuenta
    /// </summary>
    public string AccountId { get; private set; }

    /// <summary>
    /// Id de producto
    /// </summary>
    public string Id { get; private set; }

    /// <summary>
    /// Nombre del producto
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Indica si el producto esta activo
    /// </summary>
    public ProductState ProductState { get; private set; }

    /// <summary>
    /// Descripcion corta del producto
    /// </summary>
    public string? ShortDescription { get; private set; }

    /// <summary>
    /// Descripcion larga del producto
    /// </summary>
    public DescriptionVo? LargeDescription { get; private set; }

    /// <summary>
    /// Marca del producto
    /// </summary>
    public string? Brand { get; private set; }

    /// <summary>
    /// Multimedia del producto
    /// </summary>
    public List<Multimedia> Multimedias { get; private set; }

    /// <summary>
    /// Datos dinamicos del producto
    /// </summary>
    public List<DynamicFieldVo> DynamicFields { get; private set; }

    /// <summary>
    /// Actualiza el nombre del producto
    /// </summary>
    public void UpdateName(string name) => Name = name;

    /// <summary>
    /// Activa el producto
    /// </summary>
    public void UpdateProductState(ProductState newState) => ProductState = newState;

    /// <summary>
    /// Actualiza la descripcion corta
    /// </summary>
    public void UpdateShortDescription(string? shortDescription) => ShortDescription = shortDescription;

    /// <summary>
    /// Actualiza la descripcion larga
    /// </summary>
    public void UpdateLargeDescription(DescriptionVo? largeDescription) => LargeDescription = largeDescription;

    /// <summary>
    /// Actualiza la marca
    /// </summary
    public void UpdateBrand(string? brand) => Brand = brand;

    /// <summary>
    /// Agrega multimedias al producto
    /// </summary
    public void AddMultimedias(List<Multimedia> multimedias)
    {
        Multimedias.RemoveAll(x => multimedias.Select(e => e.MultimediaId).Contains(x.MultimediaId));

        Multimedias.AddRange(multimedias);
    }

    /// <summary>
    /// Agrega datos dinamicos al producto
    /// </summary>
    /// <param name="dynamicFields"></param>
    public void AddDynamicFields(List<DynamicFieldVo> dynamicFields)
    {
        DynamicFields.RemoveAll(x => dynamicFields.Select(e => e.Name).Contains(x.Name));
        
        DynamicFields.AddRange(dynamicFields);
    }
}