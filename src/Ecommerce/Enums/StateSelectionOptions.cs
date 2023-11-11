using System.Text.Json.Serialization;

namespace Ecommerce.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StateSelectionOptions
{
    All,
    Actives,
    Inactives
}
