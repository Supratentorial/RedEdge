using RedEdge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedEdge.Common.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace RedEdge.Desktop.Services
{
    public class ContactsService : IContactsService
    {
        private string _contactsEndpoint = "http://localhost:50376/";

        public async Task<IList<Contact>> GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(_contactsEndpoint);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync("api/contacts");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(jsonString);
                }
            }
            return contacts;
        }

        public async Task<Contact> SaveContact(Contact contact)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(_contactsEndpoint);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/contacts", contact);
                Contact savedContact = await response.Content.ReadAsAsync<Contact>();
                return savedContact;
            }
        }

        public Contact GetClientById(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
