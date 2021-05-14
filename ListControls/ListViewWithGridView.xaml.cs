using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ListViewWithGridView.xaml
    /// </summary>
    public partial class ListViewWithGridView : Window
    {
        public ListViewWithGridView()
        {
            InitializeComponent();

            List<User> items = new List<User>();
            items.Add(new User() { Name = "Bohn Doe", Age = 42, Sex = SexType.Male  , Mail = "hahahaha"});
            items.Add(new User() { Name = "Aane Doe", Age = 39, Sex = SexType.Female , Mail = "hohoho" });
            items.Add(new User() { Name = "Aammy Doe", Age = 13, Sex = SexType.Male, Mail = "hihihi" });
            items.Add(new User() { Name = "Aammy Doe", Age = 15, Sex = SexType.Male, Mail = "hihihi" });

            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Sex");
            view.GroupDescriptions.Add(groupDescription);

            view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
            view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));

            view.Filter = UserFilter;
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }
        private bool UserFilter(object item)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
                return true;

            return ((item as User).Name.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }


    public enum SexType {Male, Female }
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }

        public SexType Sex { get; set; }
    }

}
