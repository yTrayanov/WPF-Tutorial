using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for BindingDataWithCodeBehind.xaml
    /// </summary>
    public partial class BindingDataWithCodeBehind : Window
    {
        public BindingDataWithCodeBehind()
        {
            InitializeComponent();

            Binding binding = new Binding("Text");
            binding.Source = txtValue;
            lbValue.SetBinding(TextBlock.TextProperty, binding);
        }
    }
}
