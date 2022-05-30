using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BestTodoList
{
    public partial class Main : Window
    {
        public List<string> Times = new() { "10:00", "11:00", "20:00" };

        public Main()
        {
            InitializeComponent();
            TimeBox.ItemsSource = Times;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var result = DatePicker.SelectedDate.Value;

            MessageBox.Show(result.GetType().Name);
            MessageBox.Show(result.ToString());
        }
    }
}
