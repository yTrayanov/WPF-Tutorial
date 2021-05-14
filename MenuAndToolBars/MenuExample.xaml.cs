using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MenuAndToolBars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MenuExample : Window
    {
        public MenuExample()
        {
            InitializeComponent();
        }

        private void MenuItem_ExitFile(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("You sure?" , ":(" , MessageBoxButton.YesNo);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
                default:
                    break;
            }

        }

        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Text = "";
        }
    }
}
