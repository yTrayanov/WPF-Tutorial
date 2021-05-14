using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Dialogs
{
    /// <summary>
    /// Interaction logic for OpenFileDialogExamle.xaml
    /// </summary>
    public partial class OpenFileDialogExamle : Window
    {
        public OpenFileDialogExamle()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"Desktop";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Image files (*.png;*jpeg)|*.png;*.jpeg |All files(*.*)|*.*";
            openFileDialog.Multiselect = true;


            if (openFileDialog.ShowDialog() == true)
            {
                foreach(string fileName in openFileDialog.FileNames)
                {
                    lbFiles.Items.Add(Path.GetFileName(fileName));
                }
            }
        }
    }
}
