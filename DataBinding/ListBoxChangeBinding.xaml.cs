using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace DataBinding
{

    public class User : INotifyPropertyChanged
    {
        private string _name;
        public User(string name)
        {
            this.Name = name;
        }
        public string Name 
        {
            get
            {
                return this._name;
            }
            set
            {
                if(this._name != value)
                {
                    this._name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }

    /// <summary>
    /// Interaction logic for ListBoxChangeBinding.xaml
    /// </summary>
    public partial class ListBoxChangeBinding : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();
        public ListBoxChangeBinding()
        {
            InitializeComponent();

            users.Add(new User("John Doe"));
            users.Add(new User("John Doe"));

            lbUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User("New user"));
        }
        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                (lbUsers.SelectedItem as User).Name = "Random Name";
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                users.Remove(lbUsers.SelectedItem as User);
        }

    }
}
