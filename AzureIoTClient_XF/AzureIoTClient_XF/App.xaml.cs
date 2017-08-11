using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AzureIoTClient_XF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AzureIoTClient_XF.MenuPage();
        }

        //public static Tuple<ToolbarItem, ToolbarItem> SetupToolbarItems()
        public static (ToolbarItem, ToolbarItem) SetupToolbarItems()
        {
            ToolbarItem TbiNewDevice = new ToolbarItem
            {
                Text = "New Device",
            };

            ToolbarItem TbiAbout = new ToolbarItem
            {
                Text = "About"
            };

            return (TbiNewDevice, TbiAbout);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
