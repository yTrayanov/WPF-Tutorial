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

namespace Dialogs.CustomDialogExample
{
    /// <summary>
    /// Interaction logic for UsingCustomDialog.xaml
    /// </summary>
    public partial class UsingCustomDialog : Window
    {
        public UsingCustomDialog()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
        {
            CustomDialog dialog = new CustomDialog("Please enter your name:", "John Doe");
            if (dialog.ShowDialog() == true)
            {
                lblName.Text = dialog.Answer;
            }
        }

    }
}
