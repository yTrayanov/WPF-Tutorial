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

namespace RichTextControls
{
    /// <summary>
    /// Interaction logic for AdvancedFlowDocContent.xaml
    /// </summary>
    public partial class AdvancedFlowDocContent : Window
    {
        public AdvancedFlowDocContent()
        {
            InitializeComponent();
        }
    }

    public class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
