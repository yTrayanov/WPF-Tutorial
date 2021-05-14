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

namespace CreatingStuffWithCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Width = 250;
            TextBlock tb = new TextBlock();
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Margin = new Thickness(10);
            tb.Inlines.Add("An example on ");
            tb.Inlines.Add(new Run("inline ") { FontWeight = FontWeights.Bold });
            tb.Inlines.Add("using ");
            tb.Inlines.Add(new Run("inline ") { FontStyle = FontStyles.Italic });
            tb.Inlines.Add(new Run("text formating ") { Foreground=Brushes.Blue});
            tb.Inlines.Add("from ");
            tb.Inlines.Add(new Run("Code-Blick") { TextDecorations = TextDecorations.Underline });
            tb.Inlines.Add(".");
            this.Content = tb;
        }
    }
}
