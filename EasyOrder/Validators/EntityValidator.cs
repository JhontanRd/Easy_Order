using EasyOrder.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrder.Validators
{
    public static class EntityValidator<T> where T : class
    {
        public static bool IsValidName(string name)
        {
            return string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name) ? true : false;
        }
        
        public static bool IsValidEmail(string email)
        {
            return string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(email) ? true : false;
        }
        
        public static bool IsValidDate(DateTime registrationDate)
        {
            return registrationDate < DateTime.Now ? true : false;
        }
    }
}
