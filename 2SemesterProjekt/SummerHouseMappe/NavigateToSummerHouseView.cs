using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace _2SemesterProjekt.SummerHouseMappe

{
   public class NavigateToSummerHouseView : ICommand
    {
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(SummerHouseView));
        }

        public event EventHandler CanExecuteChanged;
    }
}
