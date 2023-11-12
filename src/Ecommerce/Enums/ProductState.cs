using System.Text.Json.Serialization;

namespace Ecommerce.Enums;

/// <summary>
/// Indica el stado que se encuentra el producto
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ProductState
{
    ReadyToShow,
    Hide,
    Waiting
}
