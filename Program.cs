using System;
using System.IO;

/*
Si vuole progettare un sistema per la gestione di una biblioteca.
Gli utenti registrati al sistema, fornendo 
- cognome, 
- nome,
- email, 
- password, 
- recapito telefonico,
possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD).
I documenti sono caratterizzati 
- da un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
- titolo, 
- anno, 
- settore(storia, matematica, economia, …),
- stato(In Prestito, Disponibile), 
- uno scaffale in cui è posizionato, 
- un elenco di autori (Nome, Cognome).
Per i libri si ha in aggiunta
- il numero di pagine, 
- mentre per i dvd la durata.
L’utente deve poter eseguire delle ricerche
- per codice o per titolo e, eventualmente,
effettuare dei prestiti registrando 
- il periodo (Dal/Al) del prestito e il documento.
Il sistema per ogni prestito determina un numero progressivo di tipo alfanumerico.
Deve essere possibile effettuare la ricerca dei prestiti dato
- nome e cognome di un utente.
*/

namespace csharp_biblioteca
{
    enum Stato { Disponibile, prestito }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            biblioteca b = new biblioteca("Biblioteca Civica");
            
            scaffale scaffale = new scaffale("S001");
            
            libro l1 = new libro("ISBN1", "Titolo libro", 2009, "Storia", 220);
            
            autore a1 = new autore("Robert", "Kiyosaki");
            
            l1.Autori.Add(a1);
            
            b.Documenti.Add(l1);
            
            l1.Scaffale = scaffale;

            dvd dvd1 = new dvd("Codice1", "Titolo del dvd", 2019, "Storia", 130);
            
            b.Documenti.Add(dvd1);

            utente u1 = new utente("Mario", "Rossi", "Telefono 1", "Email 1", "Password 1");

            b.Utenti.Add(u1);

            prestito p1 = new prestito("P001", new DateTime(2020, 4, 15), new DateTime(2020, 5, 15), u1, l1);

            b.Prestiti.Add(p1);

            Console.WriteLine("\n\nSearchByCodice: ISBN1\n\n");

            List<documento> results = b.SearchByCodice("ISBN1");

            foreach (documento doc in results)
            {
                Console.WriteLine(doc.ToString());

                if (doc.Autori.Count > 0)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Autori");

                    foreach (autore a in doc.Autori)
                    {
                        Console.WriteLine(a.ToString());
                        Console.WriteLine("-----------------");
                    }
                }
            }

            Console.WriteLine("\n\nSearchPrestiti per : Mario, Rossi\n\n");

            List<prestito> prestiti = b.SearchPrestiti("Mario", "Rossi");

            foreach (prestito p in prestiti)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("-----------------");
            }

            b.SaveUtenti("file.txt");

        }
    }
}
