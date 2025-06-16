using DevExpress.Mvvm;
using Miftakhov.Methods;
using Miftakhov.Models;
using Miftakhov.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Miftakhov.ViewModels
{
    internal class EditProductWindowViewModel : ViewModelBase
    {
        private readonly Methods_For_ViewModels _methods = new();

        public Products Product { get; set; }

        public ICommand SaveCommand { get; }
        public ICommand BackCommand { get; }
        public EditProductWindowViewModel(Products product)
        {
            Product = new Products
            {
                ProductId = product.ProductId,
                ProductTypeId = product.ProductTypeId,
                ProductName = product.ProductName,
                Article = product.Article,
                MinPartnerPrice = product.MinPartnerPrice,
                RollWidthMeters = product.RollWidthMeters
            };
            SaveCommand = new DelegateCommand(Save);
            BackCommand = new DelegateCommand(Back);
        }
        private void Save()
        {
            _methods.UpdateProduct(Product);
            WindowManager.OpenWindow<ProductsWindow>(new ProductsWindowViewModel());
        }

        private void Back()
        {
            WindowManager.OpenWindow<ProductsWindow>(new ProductsWindowViewModel());
        }
    }
}
