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

namespace ListControls
{
    /// <summary>
    /// Interaction logic for ListBoxExample.xaml
    /// </summary>
    public partial class ListBoxExample : Window
    {
        public ListBoxExample()
        {
            InitializeComponent();
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem("Completed WPF tutorial", 50));
            items.Add(new TodoItem("Learn C#", 90));
            items.Add(new TodoItem("Wash car", 0));
            items.Add(new TodoItem("Do your best", 40));
            items.Add(new TodoItem("Go to work", 100));
            items.Add(new TodoItem("Run 4 km", 50));

            lbTodoList.ItemsSource = items;
        }

        private void btnShowSelecteditems_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList.SelectedItems)
            {
                MessageBox.Show((o as TodoItem).Title);
            }
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = lbTodoList.SelectedIndex - 1;
            if (newIndex < 0)
            {
                newIndex = lbTodoList.Items.Count - 1;
            }

            lbTodoList.SelectedIndex = newIndex;
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = lbTodoList.SelectedIndex + 1;
            if (newIndex >= lbTodoList.Items.Count)
                newIndex = 0;

            lbTodoList.SelectedIndex = newIndex;
        }

        private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList.Items)
            {
                if ((o is TodoItem) && (o as TodoItem).Title.ToLower().Contains("c#"))
                {
                    lbTodoList.SelectedItem = o;
                    return;
                }
            }
            MessageBox.Show("There is no C# item");
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList.Items)
            {
                lbTodoList.SelectedItems.Add(o);
            }
        }

        private void lbTodoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbTodoList.SelectedItem != null)
            {
                this.Title = (lbTodoList.SelectedItem as TodoItem).Title;
            }
        }
    }
    
}
