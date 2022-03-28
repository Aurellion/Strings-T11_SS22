using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arbeiten mit strings.");
            string wiederholen;

            do
            {
                //Menü
                string auswahl;
                Console.WriteLine("1: Zeichen ersetzen.");
                Console.WriteLine("2: Vokale entfernen.");
                Console.WriteLine("3: Beenden.");

                Console.Write("Auswahl:");
                auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                        Console.WriteLine("Zeichen sollen ersetzt werden.");
                        string zuErsetzen, zeichen, ersatz; ;
                        Console.WriteLine("Zeichenkette eingeben:");
                        zuErsetzen = Console.ReadLine();
                        Console.WriteLine("Welches Zeichen soll ersetzt werden?");
                        zeichen = Console.ReadLine();
                        Console.WriteLine("Wodurch soll " + zeichen + " ersetzt werden?");
                        ersatz = Console.ReadLine();
                        Console.WriteLine("Es wird "+zeichen+" durch "+ersatz+" ersetzt:");

                        string ersetzt = "";
                        ersetzt = zuErsetzen.Replace(zeichen, ersatz);
                        //for (int i = 0; i < zuErsetzen.Length; i++)
                        //{
                        //    if(zuErsetzen[i].ToString() == zeichen)
                        //    {
                        //        ersetzt += ersatz;
                        //    }
                        //    else
                        //    {
                        //        ersetzt += zuErsetzen[i];
                        //    }
                        //}
                        Console.WriteLine(zuErsetzen + " wird zu: " + ersetzt);
                        break;
                    case "2":
                        Console.WriteLine("Vokale sollen entfernt werden.");
                        string zeichenkette;
                        Console.WriteLine("Zeichenkette eingeben:");
                        zeichenkette = Console.ReadLine();
                        string ergebnis = "";
                        ergebnis = zeichenkette.Replace("a","");//...
                        Console.WriteLine(zeichenkette + " wird zu " + ergebnis);
                        break;
                    case "3":
                        Console.WriteLine("Programm wird beendet.");
                        
                        break;

                    default:
                        Console.WriteLine("Auswahl ungültig.");
                        break;
                }
                Console.WriteLine("Neue Auswahl? (j/n)");
                wiederholen = Console.ReadLine();
            } while (wiederholen == "j" || wiederholen == "J");
        }
    }
}
