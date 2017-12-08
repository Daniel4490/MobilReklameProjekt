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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MobilReklameApp.XamlPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateANote : Page
    {
        public CreateANote()
        {
            this.InitializeComponent();
        }

        public void BackToMainPageClick(object sender, RoutedEventArgs g)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        public void GoToCreateOrderPage(object sender, RoutedEventArgs z)
        {
            this.Frame.Navigate(typeof(CreateOrderPage), null);
        }

        public void GoToOrderOverViewPage(object sender, RoutedEventArgs l)
        {
            this.Frame.Navigate(typeof(OrderOverView1), null);
        }



    }
}
