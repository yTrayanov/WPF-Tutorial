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
    /// Interaction logic for ItemsPanelControl.xaml
    /// </summary>
    public partial class ItemsPanelControl : Window
    {
        public ItemsPanelControl()
        {
            InitializeComponent();

            List<Item> items = new List<Item>();
            items.Add(new Item("first"));
            items.Add(new Item("second"));
            items.Add(new Item("third"));
            items.Add(new Item("forth"));

            icItems.ItemsSource = items;
        }
    }

    public class Item
    {
        public Item(string title)
        {
            this.Title = title;
        }
        public string Title { get; set; }
    }
}
