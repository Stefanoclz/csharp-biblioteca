using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Biblioteca
    {

        public Biblioteca()
        {
            Console.WriteLine("inserisci nome");
            string nome = Console.ReadLine();

            Console.WriteLine("inserisci cognome");
            string cognome = Console.ReadLine();

            Console.WriteLine("inserisci password");
            string password = Console.ReadLine();

            Console.WriteLine("inserisci email");
            string email = Console.ReadLine();

            Console.WriteLine("inserisci telefono");
            string telefono = Console.ReadLine();

            User utente = new User(nome, cognome, email, password, telefono);

            if(utente.isLoggedIn == true)
            {
                Console.WriteLine("Utente registrato con successo!");
            } else
            {
                Console.WriteLine("Dati inseriti errati");
            }
        }
    }
}
