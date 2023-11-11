using Ecommerce.Enums;

namespace Ecommcerce.Web.Admin.Products.ViewModels
{
    public class ProductsFiltersVm
    {
        /// <summary>
        /// Filtrar por listado de de ids de productos
        /// </summary>
        public IEnumerable<string>? ProductIds { get; set; }

        /// <summary>
        /// Filtrar por contenido en el nombre
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Filtra por productos en un estado
        /// </summary>
        public StateSelectionOptions StateSelection { get; set; }

        /// <summary>
        /// Filtrar por un listado de marcas
        /// </summary>
        public IEnumerable<string>? Brands { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Page { get; set; }
    }
}
