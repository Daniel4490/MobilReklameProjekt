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
using MobilReklameApp.DomainClasses;
using MobilReklameApp.XamlPages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MobilReklameApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public void OrderOverViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OrderOverView1), null);
        }

        public void CreateOrderPageClick(object sender, RoutedEventArgs f)
        {
            this.Frame.Navigate(typeof(CreateOrderPage), null);
        }

        public void CreateANoteClick(object sender, RoutedEventArgs o)
        {
            this.Frame.Navigate(typeof(CreateANote), null);
        }

        public void CustomerBaseClick(object sender, RoutedEventArgs t)
        {
            this.Frame.Navigate(typeof(CustomerBasePage), null);
        }

    }
}
