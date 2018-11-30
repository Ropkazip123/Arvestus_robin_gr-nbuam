using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestus_Robin_grünbaum
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int counter = 1;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string kasutajanimi = "user";
            string parool = "SecretPassword";

            if (counter <= 3)
            {
                if (userBox.Text == kasutajanimi && passwordBox.Password == parool)
                {
                    this.Frame.Navigate(typeof(content));
                }
                else
                {
                    counter++;
                    resultBox.Text = "Sisselogimine ebaõnnestus!";
                }
            }
            else
            {
                resultBox.Text = "Sisselogimine ebaõnnestus. Rohkem katseid sisenemiseks ei ole!";
            }
        }
    }
}
