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
    internal class ProductsWindowViewModel : ViewModelBase
    {
        private readonly Methods_For_ViewModels _methods = new();

        public ObservableCollection<Products> Products { get; set; }
        public Products SelectedProduct { get; set; }
        public ICommand DeleteProductCommand { get; }
        public ICommand AddProductCommand { get; }
        public ICommand EditProductCommand { get; }
        public ICommand BackCommand { get; }
        public ProductsWindowViewModel() 
        {
            Products = _methods.LoadProduct();
            DeleteProductCommand = new DelegateCommand(DeleteProduct, () => SelectedProduct != null);
            AddProductCommand = new DelegateCommand(OpeAddProductWindow);
            EditProductCommand = new DelegateCommand(OpenEditPartherWindow, () => SelectedProduct != null);
            BackCommand = new DelegateCommand(BackWindow);
        }
        private void DeleteProduct() => _methods.DeleteProduct(Products, SelectedProduct);
        private void OpeAddProductWindow() => WindowManager.OpenWindow<AddProductWindow>(new AddProductWindowViewModel());
        private void OpenEditPartherWindow()
        {
            if (SelectedProduct != null)
            {
                WindowManager.OpenWindow<EditProductWindow>(new EditProductWindowViewModel(SelectedProduct));
            }
        }
        private void BackWindow() => WindowManager.OpenWindow<MainWindow>(new MainWindowViewModel());
    }
}
