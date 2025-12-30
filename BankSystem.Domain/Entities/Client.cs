using System;

namespace BankSystem.Domin.Entities
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
            if (string.IsNullOrWhiteSpace(fname)))
                throw new Exception("Имя не может быть пустым");
            if (string.IsNullOrWhiteSpace(lname))
                throw new Exception("Фамилия не может быть пустой");
            if (string.IsNullOrWhiteSpace(phone))
                throw new Exception("Номер телефона обязателен")
            if(string.IsNullOrWhiteSpace(email)))
                throw new Exception("Почта обязательна");
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Email = email;
            Id = id;
        }

        public void Rename(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        public void ChangePhone(string phone)
        {
            Phone = phone;
        }

        public void ChangeEmail(string email)
        {
            Email = email;
        }
    }
}