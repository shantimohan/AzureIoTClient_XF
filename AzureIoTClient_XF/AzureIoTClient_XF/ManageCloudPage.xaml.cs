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
	public partial class ManageCloudPage : ContentPage
	{
		public ManageCloudPage ()
		{
			InitializeComponent ();

            (ToolbarItem TbiNewDevice, ToolbarItem TbiAbout) = App.SetupToolbarItems();
            this.ToolbarItems.Add(TbiNewDevice);
            this.ToolbarItems.Add(TbiAbout);
        }
    }
}