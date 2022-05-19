using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class utente : Persona
    {
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { private get; set; }

        public utente(string Nome, string Cognome, string Telefono, string Email, string Password) : base(Nome, Cognome)
        {
            this.Telefono = Telefono;
            this.Email = Email;
            this.Password = Password;
        }

        public override string ToString()
        {
            return string.Format("Nome:{0}\nCognome:{1}\nTelefono:{2}\nEmail:{3}\nPassword:{4}",
                this.Nome,
                this.Cognome,
                this.Telefono,
                this.Email,
                this.Password);
        }
    }
}