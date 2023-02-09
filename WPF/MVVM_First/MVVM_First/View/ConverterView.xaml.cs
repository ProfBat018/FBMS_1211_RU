using MVVM_First.Services.Classes;
using MVVM_First.ViewModel;
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

namespace MVVM_First.View
{
    /// <summary>
    /// Interaction logic for ConverterView.xaml
    /// </summary>
    public partial class ConverterView : Window
    {
        public ConverterView()
        {
            InitializeComponent();

            DataContext = new ConverterViewModel(new FillCurrencyService(), new CurrencyClient());
        }
    }
}
