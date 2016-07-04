using Template10.Mvvm;

namespace RedEdge.Desktop.ViewModels
{
    public class ContactListViewModel : ViewModelBase
    {
        public void GoToAddContact()
        {
            NavigationService.Navigate(typeof(Views.AddContactView), 0);
        }
    }
}
