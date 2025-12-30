using System;
using BankSystem.Domin.Entities

namespace BankSystem.Infrastructure
{
    public class Clients
    {
        private List<Client> _clients = new List<Client>();
        private int _nextId = 1;

        public List<Client> GetAll() => _clients;

        public void Add (Client client)
        {
            var client = new Client (_nextId++)
            _clients.Add(client);
        }

        public void Delete(Client client)
        {
            _clients.Remove(client);
        }
    }
}