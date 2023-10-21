namespace EcommerceKernel.ValueObjects
{
    /// <summary>
    /// Representa un dato dinamico, permite guardar valores que no estan definidos en el modelo y son muy propios de cada implementacion
    /// </summary>
    /// <param name="Name">Nombre del dato dinamico</param>
    /// <param name="Value">Valor del dato dinamico</param>
    public record DynamicFieldVo(string Name, string Value);
}
