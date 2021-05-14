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
    /// Interaction logic for FlowDocumentPageViewerExample.xaml
    /// </summary>
    public partial class FlowDocumentPageViewerExample : Window
    {
        public FlowDocumentPageViewerExample()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            fdViewer.Find();
        }
    }
}
