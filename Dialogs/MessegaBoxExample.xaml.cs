using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Dialogs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MessegaBoxExample : Window
    {
        public MessegaBoxExample()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Would you like to greet the world with a \"Hello, world\"?", "My App", MessageBoxButton.YesNoCancel , MessageBoxImage.Asterisk ,MessageBoxResult.Yes);

            switch (result)
            {
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Never mind", "My App");
                    break;
                case MessageBoxResult.Yes:
                    MessageBox.Show("Hello to you too!", "My App");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Too bad", "My App");
                    break;
                default:
                    break;
            }
        }
    }
}
