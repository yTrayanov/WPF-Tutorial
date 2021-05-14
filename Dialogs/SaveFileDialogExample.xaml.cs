using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Dialogs
{
    /// <summary>
    /// Interaction logic for SaveFileDialogExample.xaml
    /// </summary>
    public partial class SaveFileDialogExample : Window
    {
        public SaveFileDialogExample()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"Desctop";
            saveFileDialog.Filter = "Text file(*.txt)|*.txt| C# file (*.cs)|*.cs";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            }
        }
    }
}
