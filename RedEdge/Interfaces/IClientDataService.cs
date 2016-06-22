using RedEdge.Common.Models;
using System.Collections.Generic;

namespace RedEdge.Interfaces
{
    interface IClientDataService
    {
        IList<Client> GetAllClients();
        Client GetClientById(int clientId);
    }
}
