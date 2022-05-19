using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class biblioteca
    {
        public string Nome { get; set; }
        public List<documento> Documenti { get; set; }
        public List<prestito> Prestiti { get; set; }

        public List<utente> Utenti { get; set; }
        public ListaUtenti MiaListaUtenti { get; set; }


        public biblioteca(string Nome)
        {
            this.Nome = Nome;
            this.Documenti = new List<documento>();
            this.Prestiti = new List<prestito>();
            this.Utenti = new List<utente>();
        }

        public void SaveUtenti(string filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);
                foreach (utente user in this.Utenti)
                {
                    string creaStringa = user.Nome + ";" + user.Cognome + ";" + user.Email;
                    sw.WriteLine(creaStringa);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Salvataggio effettuato con successo");
            }


        }

        public void RestoreUtenti(string filename, utente user)
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader(filename);
                line = sr.ReadLine();
                while (line != null)
                {
                    line.Split(";");

                    this.Utenti.Add(user);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Lettura effettuata con successo");
            }

        }

        public List<documento> SearchByCodice(string Codice)
        {
            return this.Documenti.Where(d => d.Codice == Codice).ToList();
        }

        public List<documento> SearchByTitolo(string Titolo)
        {
            return this.Documenti.Where(d => d.Titolo == Titolo).ToList();
        }

        public List<prestito> SearchPrestiti(string Numero)
        {
            return this.Prestiti.Where(p => p.Numero == Numero).ToList();
        }

        public List<prestito> SearchPrestiti(string Nome, string Cognome)
        {
            return this.Prestiti.Where(p => p.Utente.Nome == Nome && p.Utente.Cognome == Cognome).ToList();
        }
    }
}