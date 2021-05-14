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

namespace MiscControls
{
    /// <summary>
    /// Interaction logic for DatePickerControl.xaml
    /// </summary>
    public partial class DatePickerControl : Window
    {
        public DatePickerControl()
        {
            InitializeComponent();
            dp1.BlackoutDates.AddDatesInPast();
            dp1.BlackoutDates.Add(new CalendarDateRange(DateTime.Now, DateTime.Now.AddDays(7)));
        }
    }
}
