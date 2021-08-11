using System;

namespace Spiel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Erstellen Sie das Spiel Schere, Stein, Papier, in einer Konsolenanwendung. 
             Der Benutzer soll "Schere", "Stein" oder "Papier" eingeben.
             Der Pc entscheidet sich per zufallszahl und gibt den gewinner aus.*/

            do
            {
                Random zufall = new Random();
                int comp = zufall.Next(1, 4);
                Console.WriteLine("Bitte wähle: Schere, Stein, Papier");
                string user = Console.ReadLine().ToLower();

                switch (comp)
                {
                    case 1:  //Schere
                        if (user == "schere") Console.WriteLine("Computer: Schere \r\n Unentschieden");
                        else if (user == "stein") Console.WriteLine("Computer: Schere \r\n Du hast gewonnen");
                        else if (user == "papier") Console.WriteLine("Computer: Schere \r\n Du hast verloren");
                        break;

                    case 2:  //Stein
                        if (user == "schere") Console.WriteLine("Computer: Stein \r\n Du hast verloren");
                        else if (user == "stein") Console.WriteLine("Computer: Stein \r\n Unentschieden");
                        else if (user == "papier") Console.WriteLine("Computer: Stein \r\n Du hast gewonnen");
                        break;

                    case 3:  //Papier
                        if (user == "schere") Console.WriteLine("Computer: Papier \r\n Du hast gewonnen");
                        else if (user == "stein") Console.WriteLine("Computer: Papier \r\n Du hast verloren");
                        else if (user == "papier") Console.WriteLine("Computer: Papier \r\n Unentschieden");
                        break;

                    default:
                        Console.WriteLine("Du musst Schere, Stein oder Papier wählen");
                        break;
                }
                Console.WriteLine("**************************************");

            } while (true);


        }

    }
}
