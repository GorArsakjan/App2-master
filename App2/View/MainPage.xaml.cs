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
using App2;
using App2.Model;
using App2.ViewModel;
using ProjectApp1;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjectApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainPageViewModel mainPageViewModel = new MainPageViewModel();
        MainPageModel mainPageModel = new MainPageModel();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            if (MySplitView.IsPaneOpen)
            {

                LoginGrid.Margin = new Thickness(200,0,0,0);
                WeekOfferGrid.Margin = new Thickness(759,0,0,0);
            }
            if (!MySplitView.IsPaneOpen)
            {
                WeekOfferGrid.Margin = new Thickness(559, 0, 0, 0);
                LoginGrid.Margin = new Thickness(56, 0, 0, 0);
            }
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ShareListBoxItem.IsSelected) { ResultTextBlock.Text = "Share"; }
            else if (HomeListBoxItem.IsSelected) { ResultTextBlock.Text = "Favorites"; }
        }

        private void RegisterHyperlinkButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (RegisterPage));
        }

        private void LogInButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (mainPageModel.email.Contains(UserNameBox.Text))
            {
                    Frame.Navigate(typeof (MainPage2));

            }
            else if (UserNameBox.Text.Equals(""))
            {
                UserNameBox.PlaceholderText = "Enter your e-mail addres!";
            }

            
        }

        private void Home_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (MainPage));
        }

        private void Map_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Map));
        }

        private void Region_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (RegionPage));
        }

        private void GoogleHyperlinkButton_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}
