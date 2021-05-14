using System.Windows;
using System.Windows.Media;

namespace MiscControls
{
    /// <summary>
    /// Interaction logic for SliderControl.xaml
    /// </summary>
    public partial class SliderControl : Window
    {
        public SliderControl()
        {
            InitializeComponent();
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
            this.Background = new SolidColorBrush(color);
        }
    }
}
