namespace Ecommerce.Store.Actions.Products.Inputs
{
    public class GetProductsFilters
    {
        public GetProductsFilters(string accountId,
                                      IEnumerable<string>? productIds,
                                      string? name,
                                      bool? isActive,
                                      IEnumerable<string>? brands,
                                      int page = 1,
                                      int itemsPerPage = 10)
        {
                
            AccountId = accountId;
            ProductIds = productIds;
            Name = name;
            IsActive = isActive;
            Brands = brands;
            Page = page;
            ItemsPerPage = itemsPerPage;
        }

        public GetProductsFilters()
        {
            AccountId = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        public string AccountId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<string>? ProductIds { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string? Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool? IsActive { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<string>? Brands { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Page { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ItemsPerPage { get; set; }
    }
}
