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
                Console.WriteLine("3: Quersumme berechnen.");
                Console.WriteLine("4: auf Kleinbuchstaben prüfen.");
                Console.WriteLine("5: Beenden.");

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
                        string zeichenketteAlt = zeichenkette;
                        string vokale = "aieouAIEOU";
                        string ersetzt2 = "";

                        for (int i = 0; i < vokale.Length; i++)
                        {
                            //zeichenkette = zeichenkette.Replace(vokale[i].ToString(),"");
                            for (int j = 0; j < zeichenkette.Length; j++)
                            {
                                if (zeichenkette[j] == vokale[i])
                                {
                                    ersetzt2 += "";
                                }
                                else
                                {
                                    ersetzt2 += zeichenkette[i];
                                }
                            }
                        }
                        Console.WriteLine(zeichenketteAlt + " wird zu " + zeichenkette);
                        break;
                    case "3":
                        Console.WriteLine("Die Quersumme einer ganzen Zahl soll berechnet werden.");
                        Console.Write("Eine ganze Zahl eingeben:");
                        string zahl = Console.ReadLine();
                        int quersumme = 0;                        
                        for (int i = 0; i < zahl.Length; i++)
                        {
                            quersumme += Convert.ToInt32( zahl[i].ToString() );
                        }
                        Console.WriteLine("Die Quersumme von " + zahl + " ist: " +quersumme);

                        break;
                    case "4":
                        Console.WriteLine("Ein String wird auf Kleinbuchstaben untersucht.");
                        Console.Write("Eine Zeichenkette eingeben:");
                        string wort = Console.ReadLine();
                        for (int i = 0; i < wort.Length; i++)
                        {
                            
                        }
                        
                        break;
                    case "5":
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
