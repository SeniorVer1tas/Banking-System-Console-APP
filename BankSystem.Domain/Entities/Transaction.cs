using System;
using BankSystem.Domin.Enums;

namespace BankSystem.Domin.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } =  DateTime.Now;
    }
}