using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExample.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
