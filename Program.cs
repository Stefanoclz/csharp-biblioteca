// See https://aka.ms/new-console-template for more information

using csharp_biblioteca;

Console.WriteLine("Menu Biblioteca");
Console.WriteLine("1. Registrati");
Console.WriteLine("2. Login");

int scelta1 = Int32.Parse(Console.ReadLine());

if(scelta1 == 1)
{
    Biblioteca uno = new Biblioteca();
    uno.NewUser();
} else if(scelta1 == 2)
{
    Console.WriteLine("Inserisci nome utente per effettuare il login");
    string logUser = Console.ReadLine();


    Console.WriteLine("Inserisci password utente per effettuare il login");
    string pwUser = Console.ReadLine();

    bool test = new Biblioteca().CheckUser(logUser, pwUser);

    if(test == true)
    {
        Console.WriteLine("Accesso effettuato!");
    }
    else
    {
        Console.WriteLine("Utente non trovato");
    }
}
