using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AzureIoTClient_XF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();

            (ToolbarItem TbiNewDevice, ToolbarItem TbiAbout) = App.SetupToolbarItems();
            this.ToolbarItems.Add(TbiNewDevice);
        }
    }
}