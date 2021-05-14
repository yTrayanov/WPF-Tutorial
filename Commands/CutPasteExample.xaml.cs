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

namespace Commands
{
    /// <summary>
    /// Interaction logic for CutPasteExample.xaml
    /// </summary>
    public partial class CutPasteExample : Window
    {
        public CutPasteExample()
        {
            InitializeComponent();
        }

		private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
		}

		private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			txtEditor.Cut();
		}

		private void PasteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = Clipboard.ContainsText();
		}

		private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			txtEditor.Paste();
		}
	}
}
