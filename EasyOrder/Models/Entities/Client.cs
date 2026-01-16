using EasyOrder.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrder.Models.Entities
{
    class Client
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime RegistrationDate { get; private set; }

        public Client(string name, string email, DateTime registrationDate)
        {           
            Name = name;
            Email = email;
            RegistrationDate = registrationDate;
        }

        public override string ToString()
        {
            return $"-> ID: {Id}, Nome: {Name}, E-mail: {Email},\n\tData de cadastro: {RegistrationDate.ToLongDateString()}";
        }
    }
}
