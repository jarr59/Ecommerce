namespace Ecommerce.CommonClass
{
    public class Pagination<T> where T : class
    {
        public Pagination(IEnumerable<T> collection, 
                          int page, 
                          int itemPerPage, 
                          int totalItemsCount)
        {
            Collection = collection;
            Page = page;
            ItemPerPage = itemPerPage;
            TotalItemsCount = totalItemsCount;
        }

        /// <summary>
        /// Elementos encontrados
        /// </summary>
        public IEnumerable<T> Collection { get; set; }

        /// <summary>
        /// Pagina actual
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Elementos por pagina
        /// </summary>
        public int ItemPerPage { get; set; }

        /// <summary>
        /// Total de items
        /// </summary>
        public int TotalItemsCount { get; set; }

        /// <summary>
        /// Devuelve el total de paginas
        /// </summary>
        /// <returns></returns>
        public int TotalPages()
        {
            decimal result = TotalItemsCount / ItemPerPage;

            int countPage = (int)Math.Ceiling(result);

            return countPage;
        }
    }
}
