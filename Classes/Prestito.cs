using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class prestito
    {

        public String Numero { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public utente Utente { get; set; }
        public documento Documento { get; set; }

        public prestito(String Numero, DateTime Dal, DateTime Al, utente Utente, documento Documento)
        {
            this.Numero = Numero;
            this.Dal = Dal;
            this.Al = Al;
            this.Utente = Utente;
            this.Documento = Documento;
            this.Documento.Stato = Stato.prestito;
        }

        public override string ToString()
        {
            return string.Format("Numero:{0}\nDal:{1}\nAl:{2}\nStato:{3}\nUtente:\n{4}\nDocumento:\n{5}",
                this.Numero,
                this.Dal,
                this.Al,
                this.Documento.Stato,
                this.Utente.ToString(),
                this.Documento.ToString());
        }
    }
}