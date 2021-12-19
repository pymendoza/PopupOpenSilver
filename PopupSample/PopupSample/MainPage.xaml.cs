using System;
using System.Windows;
using System.Windows.Controls;

namespace PopupSample
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void currentUser_Click(object sender, RoutedEventArgs e)
        {
            userActions.IsOpen = !userActions.IsOpen;
        }

        private void userActions_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

        private void userActions_Closed(object sender, EventArgs e)
        {

        }
    }
}