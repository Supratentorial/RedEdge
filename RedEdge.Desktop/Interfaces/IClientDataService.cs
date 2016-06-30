
using RedEdge.Common.Models;
using System.Collections.Generic;

namespace RedEdge.Interfaces
{
    interface IClientDataService
    {
        IList<Contact> GetAllClients();
        Contact GetClientById(int clientId);
    }
}
