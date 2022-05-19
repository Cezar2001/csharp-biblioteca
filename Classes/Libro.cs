using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class libro : documento
    {
        public int NumeroPagine { get; set; }
        public libro(string Codice, string Titolo, int Anno, string Settore, int NumeroPagine)
            : base(Codice, Titolo, Anno, Settore)
        {
            this.NumeroPagine = NumeroPagine;
        }
        public override string ToString()
        {
            return string.Format("{0}\nNumeroPagine:{1}", base.ToString(), this.NumeroPagine);
        }
    }
}