using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jakolaskuri
{
    /// <summary>
    /// Interaction logic for koostettuKomponentti.xaml
    /// </summary>
    public partial class koostettuKomponentti : UserControl
    {
        //private int jaettava, jakaja;

        public koostettuKomponentti()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty jaettavaProperty = DependencyProperty.Register(
            "jaettava", typeof(int),
            typeof(koostettuKomponentti),
            new FrameworkPropertyMetadata(0));

        public int jaettava
        {
            get { return (int)GetValue(jaettavaProperty); }
            set { SetValue(jaettavaProperty, value); }
        }

        public static readonly DependencyProperty jakajaProperty = DependencyProperty.Register(
            "jakaja", typeof(int),
            typeof(koostettuKomponentti),
            new FrameworkPropertyMetadata(0));

        public int jakaja
        {
            get { return (int)GetValue(jakajaProperty); }
            set { SetValue(jakajaProperty, value); }
        }

        private void JaaNappi_Click(object sender, RoutedEventArgs e)
        {
            JakoTulos.Content = string.Format("{0:0.00}", (double)jaettava / (double)jakaja);
        }

        private void JaettavaBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txbox = (TextBox)sender;
            jaettava = int.Parse(txbox.Text);
        }

        private void JakajaBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txbox = (TextBox)sender;
            jakaja = int.Parse(txbox.Text);
        }
    }
}
