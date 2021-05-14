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

namespace CheckBoxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbAllFeatures_Checked(object sender, RoutedEventArgs e)
        {
            bool isChecked = (cbAllFeatures.IsChecked == true);
            cbFeatureAbc.IsChecked = isChecked;
            cbFeatureXyz.IsChecked = isChecked;
            cbFeatureWww.IsChecked = isChecked;
        }

        private void cbFeature_Checked(object sender , RoutedEventArgs e)
        {
            cbAllFeatures.IsChecked = null;
            if(cbFeatureAbc.IsChecked == true && cbFeatureXyz.IsChecked == true && cbFeatureWww.IsChecked == true)
            {
                cbAllFeatures.IsChecked = true;
            }

            if (cbFeatureAbc.IsChecked == false && cbFeatureXyz.IsChecked == false && cbFeatureWww.IsChecked == false)
            {
                cbAllFeatures.IsChecked = false;
            }
        }
    }
}
