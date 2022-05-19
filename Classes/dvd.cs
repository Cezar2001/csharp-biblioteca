using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class dvd : documento
    {
        public int Durata { get; set; }
        public dvd(string Codice, string Titolo, int Anno, string Settore, int Durata)
            : base(Codice, Titolo, Anno, Settore)
        {
            this.Durata = Durata;
        }
        public override string ToString()
        {
            return string.Format("{0}\nDurata:{1}", base.ToString(), this.Durata);
        }
    }
}