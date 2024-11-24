using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ecommerce.Products;
using System.Collections.ObjectModel;

namespace Ecommerce.Web.Views.Products.Components.ViewModels
{
    public partial class ProductViewModel : ObservableObject
    {
        public ProductViewModel()
        {
                
        }

        /// <summary>
        /// Productos devueltos
        /// </summary>
        public ObservableCollection<ProductOutput>? Products { get; set; }

        [RelayCommand]
        public async Task GetProducts()
        {

        }
    }
}
