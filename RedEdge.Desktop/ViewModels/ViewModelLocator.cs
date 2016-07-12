using Autofac;
using Autofac.Extras.CommonServiceLocator;
using Microsoft.Practices.ServiceLocation;
using RedEdge.Desktop.Services;
using RedEdge.Interfaces;

namespace RedEdge.Desktop.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ContactsService>().As<IContactsService>();
            builder.RegisterType<MainPageViewModel>();
            builder.RegisterType<AddContactViewModel>();
            builder.RegisterType<ContactListViewModel>();
            builder.RegisterType<MatterListViewModel>();
            builder.RegisterType<DetailPageViewModel>();
            builder.RegisterType<SettingsPageViewModel>();

            var container = builder.Build();
            var commonServiceLocator = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => commonServiceLocator);
        }

        public MainPageViewModel MainPageViewModel
        {
            get { return ServiceLocator.Current.GetInstance<MainPageViewModel>(); }
        }

        public AddContactViewModel AddContactViewModel
        {
            get { return ServiceLocator.Current.GetInstance<AddContactViewModel>(); }
        }



    }
}
