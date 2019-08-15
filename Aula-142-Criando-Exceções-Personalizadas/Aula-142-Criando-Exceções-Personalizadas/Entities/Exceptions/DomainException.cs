using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_142_Criando_Exceções_Personalizadas.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string messege) : base(messege)
        {
        }

    }
}
