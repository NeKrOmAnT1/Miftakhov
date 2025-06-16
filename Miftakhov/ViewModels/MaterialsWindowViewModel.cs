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
using System.Windows.Media.Media3D;


namespace Miftakhov.ViewModels
{
    internal class MaterialsWindowViewModel : ViewModelBase
    {
        private readonly Methods_For_ViewModels _methods = new();

        public ObservableCollection<Models.Material> Materials { get; set; }
        public ICommand BackCommand { get; }
        public MaterialsWindowViewModel()
        {
            Materials = _methods.LoadMaterail();
            BackCommand = new DelegateCommand(BackWindow);

        }
        private void BackWindow() => WindowManager.OpenWindow<MainWindow>(new MainWindowViewModel());
    }
}
