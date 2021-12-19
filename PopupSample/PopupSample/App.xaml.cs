using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PopupSample
{
    public sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            // Enter construction logic here...
            this.RootVisual = new MainPage();

            //var mainPage = new MainPage();
            //Window.Current.Content = mainPage;
        }
    }
}
