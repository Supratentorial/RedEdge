using RedEdge.Common.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedEdge.Interfaces
{
    public interface IContactsService
    {
        Task<IList<Contact>> GetAllContacts();
        Contact GetClientById(int clientId);
        Task<Contact> SaveContact(Contact contact);
    }
}
