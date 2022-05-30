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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactoryMethodWPF
{
    public partial class MainWindow : Window
    {
        public List<IProduct> Products { get; set; } = new()
        {
            new Drink() { Name = "Pepsi", Price = 1.80f },
            new Drink() { Name = "Cola", Price = 2.20f },
            new Drink() { Name = "Ayran Naneli", Price = 0.70f }
        };

        public List<string> Cards { get; set; } = new() { "Visa", "Mastercard" };
        public List<string> Cryptoes { get; set; } = new() { "Bitcoin", "Dogecoin", "Etherium" };


        public MainWindow()
        {
            InitializeComponent();

            foreach (var item in Products)
            {
                ProductsBox.Items.Add(item);
            }
            BuyButton.IsEnabled = false;
        }

        private bool CheckCount()
        {
            var tmp = 0;
            bool state = Int32.TryParse(Count.Text, out tmp);

            return state && tmp > 0;
        }

        private void BuyWithCash()
        {
            if (CheckCount() && CashRadio.IsChecked == true)
                ProductsForBuy.Items.Add(ProductsBox.SelectedItem);
        }
     
        private void CashRadio_Checked(object sender, RoutedEventArgs e)
        {
            CardAndCryptoBox.IsEnabled = false;
        }
        private void CardRadio_Checked(object sender, RoutedEventArgs e)
        {
            CardAndCryptoBox.IsEnabled = true;
            CardAndCryptoBox.Items.Clear();
            foreach (var item in Cards)
            {
                CardAndCryptoBox.Items.Add(item);
            }
            CardAndCryptoBox.SelectedIndex = 0;
        }
        private void Crypto_Checked(object sender, RoutedEventArgs e)
        {
            CardAndCryptoBox.IsEnabled = true;
            CardAndCryptoBox.Items.Clear();
            foreach (var item in Cryptoes)
            {
                CardAndCryptoBox.Items.Add(item);
            }
            CardAndCryptoBox.SelectedIndex = 0;

        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            BuyWithCash();
        }
    }
}
