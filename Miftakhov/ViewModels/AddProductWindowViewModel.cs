using DevExpress.Mvvm;
using Miftakhov.Methods;
using Miftakhov.Models;
using Miftakhov.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Miftakhov.ViewModels
{
    internal class AddProductWindowViewModel : ViewModelBase
    {
        private readonly Methods_For_ViewModels _methods = new();
        public ObservableCollection<Products> Products { get; set; }
        public Products Product { get; set; } = new();
        public ICommand SaveProductCommand { get; }
        public ICommand BackCommand { get; }
        public AddProductWindowViewModel()
        {
            SaveProductCommand = new DelegateCommand(SaveProduct);
            BackCommand = new DelegateCommand(BackWindow);
        }
        private void SaveProduct() => _methods.AddProduct(Product);
        private void BackWindow() => WindowManager.OpenWindow<ProductsWindow>(new ProductsWindowViewModel());
    }
}
