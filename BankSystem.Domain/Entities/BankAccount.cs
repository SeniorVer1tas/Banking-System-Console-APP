using System;

namespace BankSystem.Domin.Entities
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal Balance {  get; set; }

    }
}