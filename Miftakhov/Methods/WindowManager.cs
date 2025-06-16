using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Miftakhov.Methods
{
    internal class WindowManager
    {
        public static void OpenWindow<T>(object viewModel = null) where T : Window, new()
        {
            var window = new T();
            window.DataContext = viewModel;
            window.Show();

            CloseCurrentWindow();
        }

        private static void CloseCurrentWindow()
        {
            var currentWindow = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            currentWindow?.Close();
        }
    }
}
