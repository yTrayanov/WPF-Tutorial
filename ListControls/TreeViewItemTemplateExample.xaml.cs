using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ListControls
{
    /// <summary>
    /// Interaction logic for TreeViewItemTemplateExample.xaml
    /// </summary>
    public partial class TreeViewItemTemplateExample : Window
    {
        public TreeViewItemTemplateExample()
        {
            InitializeComponent();
            MenuItem root = new MenuItem() { Title = "Menu" };
            MenuItem child1 = new MenuItem() { Title = "Child item 1" };
            child1.Items.Add(new MenuItem() { Title = "child item 1.1" });
            child1.Items.Add(new MenuItem() { Title = "Child item 1.2" });
            root.Items.Add(child1);
            root.Items.Add(new MenuItem() { Title = "Child item 2" });

            tvMenu.Items.Add(root);

            Style style = new Style(typeof(TreeViewItem));
            style.Setters.Add(new Setter(TreeViewItem.IsExpandedProperty, true));
            Resources.Add(typeof(TreeViewItem),style);

        }
    }

    public class MenuItem
    {
        public MenuItem()
        {
            this.Items = new ObservableCollection<MenuItem>();
        }

        public string Title { get; set; }

        public ObservableCollection<MenuItem> Items { get; set; }
    }
}
