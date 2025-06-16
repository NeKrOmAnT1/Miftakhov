using DevExpress.Mvvm;
using Miftakhov.Methods;
using Miftakhov.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Miftakhov.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ICommand OpenProductsCommand { get; }
        public ICommand OpenMaterialCommand { get; }
        public MainWindowViewModel() 
        {
            OpenProductsCommand = new DelegateCommand(OpenProductsWindow);
            OpenMaterialCommand = new DelegateCommand(OpenMaterialWindow);
        }
        private void OpenProductsWindow()  => WindowManager.OpenWindow<ProductsWindow>(new ProductsWindowViewModel()); 
        private void OpenMaterialWindow()  => WindowManager.OpenWindow<MaterialsWindow>(new MaterialsWindowViewModel());

    }

}
