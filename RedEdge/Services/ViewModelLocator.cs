using Autofac;
using Autofac.Extras.CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using RedEdge.ClientDetails;
using RedEdge.ClientList;
using RedEdge.Interfaces;
using RedEdge.Main;

namespace RedEdge.Services
{

    public class ViewModelLocator
    {/// <summary>
     /// Initializes a new instance of the ViewModelLocator class.
     /// </summary>
        public ViewModelLocator()
        {
            var container = new ContainerBuilder();
            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container.Build()));

            if (ViewModelBase.IsInDesignModeStatic)
            {
                //Register design time services
            }
            else {

            }
            container.RegisterType<ClientDataService>().As<IClientDataService>();
            container.RegisterType<MainViewModel>();
            container.Register(c => CreateNavigationService()).As<INavigationService>();
        }

        private INavigationService CreateNavigationService() {
            var navigationService = new NavigationService();
            navigationService.Configure("ClientDetailsView", typeof(ClientDetailsView));
            navigationService.Configure("ClientListView", typeof(ClientListView));
            return navigationService;
        }
    }
}
