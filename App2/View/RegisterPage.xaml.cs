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
using App2.ViewModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjectApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterPage : Page
    {
        RegisterViewModel registerViewModel = new RegisterViewModel();
        public RegisterPage()
        {
            this.InitializeComponent();
        }

        private void ConfirmButton_OnClick(object sender, RoutedEventArgs e)
        {
            bool AllowNavigation = false;
            if (FirstNameBox.Text == "")
            {
                FirstNameBox.PlaceholderText = "Empty not allowed";
            }
             if (LastNameBox.Text == "")
            {
                LastNameBox.PlaceholderText = "Empty not allowed";
            }
             if (EMailBox.Text == "" && !EMailBox.Text.Contains("@"))
            {
                EMailBox.PlaceholderText = "Empty not allowed";
            }
             if (PasswordBox.Password.Length < 5)
            {
                PasswordBox.PlaceholderText = "Password too short";
            }
             if (CityBox.Text == "")
            {
                CityBox.PlaceholderText = "Empty not allowed";
            }
             if (ZipCodeBox.Text == "")
            {
                ZipCodeBox.PlaceholderText = "Empty not allowed";
            }
             if (AddressBox.Text == "")
            {
                AddressBox.PlaceholderText = "Empty not allowed";
            }
             if (CreditCardNumber.Text == "")
            {
                CreditCardNumber.PlaceholderText = "Empty not allowed";
            }
             if (ExpMonthBlock.Text.Length != 2 && ExpYearBox.Text.Length != 4)
            {
                ExpMonthBlock.PlaceholderText = "Empty not allowed";
                ExpYearBox.PlaceholderText = "Empty not allowed";
            }
            else
            {
                AllowNavigation = true;
            }


            if (AllowNavigation)
            {
                Frame.Navigate(typeof(MainPage2));
            }

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            if (MySplitView.IsPaneOpen)
            {
                RegisterGrid.Margin = new Thickness(200, 0, 0, 0);
                WeekOfferGrid.Margin = new Thickness(759, 0, 0, 0);
            }
            if (!MySplitView.IsPaneOpen)
            {
                WeekOfferGrid.Margin = new Thickness(559, 0, 0, 0);
                RegisterGrid.Margin = new Thickness(56, 0, 0, 0);
            }
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ShareListBoxItem.IsSelected)
            {
                
            }
            else if (HomeListBoxItem.IsSelected)
            {
                
            }
            else if (SettingsListBoxItem.IsSelected)
            {
                
            }
            else if (RegionsListBoxItem.IsSelected)
            {
                
            }
            else if (MapListBoxItem.IsSelected)
            {
                
            }

        }

        private void RegisterHyperlinkButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegisterPage));
        }

        private void LogInButton_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage2));
        }

        private void Home_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Map_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Map));
        }

        private void Region_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegionPage));
        }

        private void CreditCardNumber_OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            if (CreditCardNumber.Text.StartsWith("4"))
            {
                VisaRadioButton.IsChecked = IsEnabled;
            }
            if (CreditCardNumber.Text.StartsWith("5"))
            {
               MasterCardRadioButton.IsChecked = IsEnabled;
            }
            if (CreditCardNumber.Text.StartsWith("3"))
            {
                AmericanExpressRadioButton.IsChecked = IsEnabled;
            }
            if (CreditCardNumber.Text.StartsWith("6"))
            {
                MaestroRadioButton.IsChecked = IsEnabled;
            }
        }
    }
}
