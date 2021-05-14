using System.Collections.Generic;
using System.Windows;

namespace ListControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem("Complete this WPF tutorial", 45));
            items.Add(new TodoItem("Learn c#", 80));
            items.Add(new TodoItem("Wash the car", 0));
            items.Add(new TodoItem("Wash the car", 10));
            items.Add(new TodoItem("Wash the car", 20));
            items.Add(new TodoItem("Wash the car", 30));
            items.Add(new TodoItem("Wash the car", 40));
            items.Add(new TodoItem("Wash the car", 50));
            items.Add(new TodoItem("Wash the car", 60));
            items.Add(new TodoItem("Wash the car", 70));
            items.Add(new TodoItem("Wash the car", 80));
            items.Add(new TodoItem("Wash the car", 90));
            items.Add(new TodoItem("Wash the car", 100));

            icTodoList.ItemsSource = items; 
        }
    }
}
