using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidation
{
    public class EmailValidator
    {
        public bool ValidarEmail(string email)
        {
            // Verifica se o email contém "@" e "."
            return email.Contains("@") && email.Contains(".");
        }
    }

}
