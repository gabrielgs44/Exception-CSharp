using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioExcecao.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
