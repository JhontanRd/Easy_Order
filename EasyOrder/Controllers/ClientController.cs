using EasyOrder.Models.Entities;
using EasyOrder.Models.Exceptions;
using EasyOrder.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrder.Controllers
{
    class ClientController
    {
        public Client CreateClient(string name, string email, DateTime registrationDate)
        {
            if (EntityValidator<Client>.IsValidName(name))
                throw new EntityException("Informe um nome válido!");

          
            if (EntityValidator<Client>.IsValidEmail(email))
                throw new EntityException("Informe um e-mail válido!");
            
            if (EntityValidator<Client>.IsValidDate(registrationDate))
                throw new EntityException("Informe uma data de registro válida!");
            

            return new Client(name, email, registrationDate);
        }
    }
}
