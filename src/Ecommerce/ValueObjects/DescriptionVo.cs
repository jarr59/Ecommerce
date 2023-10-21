using Ecommerce.Enums;

namespace Ecommerce.ValueObjects;

/// <summary>
/// Representa la descripcion de un objecto, puede representarse un html, texto plano, XML, etc 
/// </summary>
/// <param name="TextualMarkup">Formato de marcado de texto</param>
/// <param name="Value">El valor ingresado</param>
public record DescriptionVo(TextualMarkup TextualMarkup, string Value);
