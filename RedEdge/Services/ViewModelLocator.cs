using Autofac;
using Autofac.Extras.CommonServiceLocator;
using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
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
        }
    }
}
