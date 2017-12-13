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
using MobilReklameApp.XamlPages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MobilReklameApp.DomainClasses
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomerBasePage : Page
    {
        public CustomerBasePage()
        {
            this.InitializeComponent();
        }

        public void BackToMainPageClick(object sender, RoutedEventArgs j)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        public void GoToCreateOrderPage(object sender, RoutedEventArgs z)
        {
            this.Frame.Navigate(typeof(CreateOrderPage), null);
        }

        public void GoToOrderOverView(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OrderOverView1), null);
        }

        public void GoToCreateANote(object sender, RoutedEventArgs o)
        {
            this.Frame.Navigate(typeof(CreateANote), null);
        }
    }
}
