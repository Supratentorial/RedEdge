using Autofac;
using Autofac.Extras.CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using RedEdge.ClientDetails;
using RedEdge.ClientList;
using RedEdge.Interfaces;
using RedEdge.Main;
using RedEdge.MatterList;

namespace RedEdge.Services
{

    public class ViewModelLocator
    {/// <summary>
     /// Initializes a new instance of the ViewModelLocator class.
     /// </summary>
     /// 
        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public ClientListViewModel ClientListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ClientListViewModel>();
            }
        }

        public MatterListViewModel MatterListViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MatterListViewModel>();
            }
        }

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();


            if (ViewModelBase.IsInDesignModeStatic)
            {
                //Register design time services
            }
            else
            {

            }
            var navigationService = new NavigationService();

            builder.RegisterType<ClientDataService>().As<IClientDataService>();
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<ClientListViewModel>();
            builder.RegisterType<MatterListViewModel>();
            builder.RegisterInstance(navigationService).AsImplementedInterfaces();
            var container = builder.Build();
            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));
        }

       
    }
}
