using System.Windows;
using System.Windows.Controls;

namespace TabControlExample
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

        private void btnPreviousTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = tcSample.Items.Count - 1;

            tcSample.SelectedIndex = newIndex;
        }

        private void SelectedTab_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected tab: " + (tcSample.SelectedItem as TabItem).Header);
        }

        private void btnNextTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex + 1;
            if(newIndex >= tcSample.Items.Count)
            {
                newIndex = 0;
            }
            tcSample.SelectedIndex = newIndex;
        }

        private void btnDoSmth_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is general page");
        }
    }
}
