using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrder.Models.Exceptions
{
    class EntityException : ApplicationException
    {
        public EntityException(string msg) : base(msg) { }
    }
}
