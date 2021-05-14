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
    /// Interaction logic for RichTextBoxExample.xaml
    /// </summary>
    public partial class RichTextBoxExample : Window
    {
        public RichTextBoxExample()
        {
            InitializeComponent();
        }

        private void btnGetText_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
            MessageBox.Show(textRange.Text);
        }
        private void btnSetText_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
            textRange.Text = "Another world, another text!";
        }
        private void btnGetSelectedText_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(rtbEditor.Selection.Text);
        }

        private void btnSetSelectedText_Click(object sender, RoutedEventArgs e)
        {
            rtbEditor.Selection.Text = "[Replaced text]";
        }

        

        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Selection.Start);
            txtStatus.Text = "Selection starts at character #" + textRange.Text.Length + Environment.NewLine;
            txtStatus.Text += "Selection is " + rtbEditor.Selection.Text.Length + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + rtbEditor.Selection.Text + "'";
        }

        
    }
}
