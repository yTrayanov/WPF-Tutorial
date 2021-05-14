using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ListControls
{
    /// <summary>
    /// Interaction logic for ComboBoxExample.xaml
    /// </summary>
    public partial class ComboBoxExample : Window
    {
        public ComboBoxExample()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            var newIndex = cmbColors.SelectedIndex - 1;
            if (cmbColors.SelectedIndex < 0)
                newIndex= cmbColors.Items.Count -1;

            cmbColors.SelectedIndex = newIndex;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            var newIndex = cmbColors.SelectedIndex + 1;
            if (cmbColors.SelectedIndex >= cmbColors.Items.Count)
                newIndex = 0;

            cmbColors.SelectedIndex = newIndex;

        }
        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            cmbColors.SelectedItem = typeof(Colors).GetProperty("Blue");
        }

        private void cmbColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColors.SelectedItem as PropertyInfo).GetValue(null, null);
            this.Background = new SolidColorBrush(selectedColor);
        }

    }
}
