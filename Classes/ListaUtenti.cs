using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class ListaUtenti
    {
        private Dictionary<Tuple<string, string, string>, utente> MyDictionary;

        public ListaUtenti()
        {
            MyDictionary = new Dictionary<Tuple<string, string, string>, utente>();
        }


        public void AggiungiUtente(utente uUtente)
        {
            var chiave = new Tuple<string, string, string>(uUtente.Nome, uUtente.Cognome, uUtente.Email);
            MyDictionary.Add(chiave, uUtente);
        }
    }
}