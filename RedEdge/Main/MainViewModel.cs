using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using RedEdge.ClientList;
using RedEdge.MatterList;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace RedEdge.Main
{
    public class MainViewModel : ViewModelBase
    {
        private List<NavMenuItem> _navList;
        private INavigationService _navigationService;

        public RelayCommand ClientListCommand { get; set; }

        public string PageTitle { get; set; }

        public MainViewModel(INavigationService navigationService)
        {

            _navList = new List<NavMenuItem>() {
                new NavMenuItem() {
                    Label = "Matters",
                    DestPage = typeof(MattersListView),
                    Symbol = Symbol.Folder,
                    Arguments = null
                },
                new NavMenuItem() {
                Label = "Contacts",
                DestPage = typeof(ClientListView),
                Symbol = Symbol.PhoneBook,
                Arguments = null}
            };

            _navigationService = navigationService;
            PageTitle = "Red Edge";

            ClientListCommand = new RelayCommand(() =>
            {
                navigationService.NavigateTo("ClientListView");
            });
        }
    }
}
