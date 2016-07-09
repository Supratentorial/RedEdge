using RedEdge.Common.Models;
using RedEdge.Interfaces;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace RedEdge.Desktop.ViewModels
{
    public class AddContactViewModel :ViewModelBase
    {
        public ObservableCollection<string> TitleOptions { get; set; }
        private IContactsService _contactsService;

        public AddContactViewModel()
        {

            TitleOptions = new ObservableCollection<string>()
            {
                "Mr", "Mrs", "Ms", "Miss", "Master", "Doctor", "Sir", "Professor"
            };
        }

        public async Task<Contact> SaveNewContact() {
            Contact newContact = new Contact() { };
            var savedContact = await _contactsService.SaveContact(newContact);
            return savedContact;
        }

        
    }
}
