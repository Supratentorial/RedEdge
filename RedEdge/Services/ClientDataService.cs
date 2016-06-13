using RedEdge.Interfaces;
using System;
using System.Collections.Generic;
using RedEdge.Models;

namespace RedEdge.Services
{
    public class ClientDataService : IClientDataService
    {
        public IList<Client> GetAllClients()
        {
            return new List<Client>() {
                new Client() { ClientId = 1, FamilyName= "Mumford", GivenName = "Blake" },
                new Client() { ClientId = 2, FamilyName = "Baggins", GivenName= "Frodo" },
                new Client() { ClientId = 3, FamilyName = "Gamgee", GivenName = "Samwise" }
            };
        }

        public Client GetClientById(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
