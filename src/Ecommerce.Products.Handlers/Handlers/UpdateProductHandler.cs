using Ecommerce.Products.Commands;
using Ecommerce.Products.Interfaces;
using MediatR;

namespace Ecommerce.Products.Handlers.Handlers;

class UpdateProductHandler : IRequestHandler<UpdateProduct, IEnumerable<Product>>
{
    readonly IProductRepo _productRepo;

    public UpdateProductHandler(IProductRepo productRepo)
    {
        _productRepo = productRepo;
    }

    public async Task<IEnumerable<Product>> Handle(UpdateProduct request, CancellationToken cancellationToken)
    {
        List<Product> productExist =
            await _productRepo.GetByIds(request.ProductsToUpdate
                                               .Where(x => !string.IsNullOrEmpty(x.ProductId))
                                               .Select(x => x.ProductId!), request.AccountId);

        List<Product> productsToCreate = new();

        foreach (UpdateProductInput productData in request.ProductsToUpdate)
        {
            Product? currentProduct = productExist.FirstOrDefault(x => x.Id == productData.ProductId);

            if (currentProduct != null)
            {
                if (!string.IsNullOrEmpty(productData.Name))
                    currentProduct.UpdateName(productData.Name);

                UpdateProduct(currentProduct, productData);
            }
            else
            {
                currentProduct = new(request.AccountId, productData.ProductId!, productData.Name!);

                UpdateProduct(currentProduct, productData);

                productsToCreate.Add(currentProduct);
            }
        }
        
        await _productRepo.Create(productsToCreate);

        await _productRepo.SaveChangesAsync();

        productsToCreate.AddRange(productExist);

        return productsToCreate;
    }
    /// <summary>
    /// Actualiza el producto
    /// </summary>
    /// <param name="currentProduct"></param>
    /// <param name="productData"></param>
    void UpdateProduct(Product currentProduct, UpdateProductInput productData)
    {
        currentProduct.UpdateProductState(productData.ProductState);

        currentProduct.UpdateShortDescription(productData.ShortDescription);

        currentProduct.UpdateLargeDescription(productData.LargeDescription);

        currentProduct.UpdateBrand(productData.Brand);

        if (productData.DynamicFields?.Any() == true)
            currentProduct.AddDynamicFields(productData.DynamicFields);
    }
}
