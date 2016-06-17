using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace RedEdge.Main
{
    public class MainViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

    }
}
