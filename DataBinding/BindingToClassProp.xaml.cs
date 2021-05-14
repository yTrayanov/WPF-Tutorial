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

namespace DataBinding
{

    public class Person
    {
        public Person(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + ' ' + SecondName;
            }
        }
    }

    /// <summary>
    /// Interaction logic for BindingToClassProp.xaml
    /// </summary>
    public partial class BindingToClassProp : Window
    {
        public BindingToClassProp()
        {
            InitializeComponent();
            this.Person = new Person("Yavor", "Trayanov");
            this.DataContext = this;
        }

        public Person Person { get; set; }

        
    }
}
