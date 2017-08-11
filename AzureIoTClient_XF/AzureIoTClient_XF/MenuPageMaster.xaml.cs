using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AzureIoTClient_XF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPageMaster : ContentPage
    {
        public ListView ListView;

        public MenuPageMaster()
        {
            InitializeComponent();

            BindingContext = new MenuPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MenuPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuPageMenuItem> MenuItems { get; set; }

            public MenuPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenuPageMenuItem>(new[]
                {
                    new MenuPageMenuItem { Id = 0, Title = "Home (Live Data)", TargetType = typeof(HomePage) },
                    new MenuPageMenuItem { Id = 1, Title = "Alerts", TargetType = typeof(AlertsPage) },
                    new MenuPageMenuItem { Id = 2, Title = "History", TargetType = typeof(HistoryPage) },
                    new MenuPageMenuItem { Id = 3, Title = "Manage Cloud", TargetType = typeof(ManageCloudPage) },
                    new MenuPageMenuItem { Id = 4, Title = "Manage Device", TargetType = typeof(ManageDevicePage) },
                    new MenuPageMenuItem { Id = 5, Title = "App Settings", TargetType = typeof(AppSettingsPage) },
                    new MenuPageMenuItem { Id = 6, Title = "Setup New Device", TargetType = typeof(SetupNewDevice) },
                    new MenuPageMenuItem { Id = 7, Title = "About and Help", TargetType = typeof(AboutPage) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}