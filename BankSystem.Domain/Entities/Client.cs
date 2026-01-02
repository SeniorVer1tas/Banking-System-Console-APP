using System;

namespace BankSystem.Domain.Entities
{
    public class Client
    {
        public int Id { get; }
        public string FirstName {  get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        public Client(int id, string fname, string lname, string phone, string email)
        {
            if (string.IsNullOrWhiteSpace(fname))
                throw new ArgumentException("Имя не может быть пустым", nameof(fname);
            if (string.IsNullOrWhiteSpace(lname))
                throw new ArgumentException("Фамилия не может быть пустой", nameof(lname);
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Номер телефона обязателен");
            if(string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Почта обязательна");
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Email = email;
            Id = id;
        }

        public void Rename(string fname, string lname)
        {
            if (string.IsNullOrWhiteSpace(fname))
                throw new ArgumentException("Имя не может быть пустым", nameof(fname));
            if (string.IsNullOrWhiteSpace(lname))
                throw new ArgumentException("Фамилия не может быть пустой", nameof(lname));
            FirstName = fname;
            LastName = lname;
        }

        public void ChangePhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Номер телефона обязателен", nameof(phone));
            Phone = phone;
        }

        public void ChangeEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Почта обязательна", nameof(email));
            Email = email;
        }
    }
}