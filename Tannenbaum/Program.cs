using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    class Program
    {
        static void Main(string[] args)
        {
            int größe, preis, kerzen = 0;
            string Modell;
            char material = 'x';
            bool zusatz = false;

            Console.Title = "Tannenbaum Einkauf";
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\nX WILLKOMMEN BEI BESSER-LEBEN X\nXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\n\nWählen Sie zwichen Einsteiger <E>, Optimist <O>,\nFamilie <F>, Business <B> oder Deluxe <D>\noder beenden Sie Sie das Programm mit Exit <X>");

            switch (Console.ReadLine().ToUpper())
            {
                case "E":
                    größe = 3;
                    preis = 7;
                    Modell = "Einsteiger";
                    break;
                case "O":
                    größe = 5;
                    preis = 10;
                    zusatz = true;
                    Modell = "Optimist";
                    break;
                case "F":
                    größe = 8;
                    preis = 15;
                    zusatz = true;
                    Modell = "Familie";
                    break;
                case "B":
                    größe = 12;
                    preis = 20;
                    Modell = "Business";
                    zusatz = true;
                    break;
                case "D":
                    größe = 12;
                    preis = 25;
                    material = 'A';
                    kerzen = 1;
                    Modell = "Deluxe";
                    break;
                case "X":
                    Console.WriteLine("Das Program wird geschlossen");
                    Console.ReadLine();
                    return;
                default:
                    Console.WriteLine("Es wurde ein ungültiger Menüpunkt gewählt!");
                    Console.ReadLine();
                    return;
            }

            if (zusatz)
            {
                Console.WriteLine("Möchten Sie auch Kerzen? (J/N)");
                if (Console.ReadLine().ToUpper() == "J") { Console.WriteLine("Kerzen wurden hinzugefügt."); kerzen = 1; größe += 1; preis += 3; }

                Console.WriteLine("Möchten Sie eine Nordmann Tanne? (J/N)");
                if (Console.ReadLine().ToUpper() == "J") { Console.WriteLine("Nordman wurden ausgewählt."); material = 'A'; preis += 4; }
            }

            Console.Clear();
            Console.WriteLine("Modell {0}: \n\n" + new string('*', größe * 2 +2) + "\n", Modell);

            for (int i = 0, nadeln = -1, leer = größe; i < größe; i++)
            {
                if (kerzen == 1)
                {
                    if (i == 0) Console.WriteLine(new string(' ', größe + 1) + 'i');
                    else { Console.WriteLine(new string(' ', leer) + 'i' + new string(material, nadeln += 2) + 'i'); leer--; }
                }
                else
                {
                    Console.WriteLine(new string(' ', leer) + new string(material, nadeln += 2));
                    leer--;
                }
            }

            Console.WriteLine(new string(' ', größe + kerzen ) + 'T' + "\n\n" + new string('*', größe * 2 +2));
            Console.WriteLine("\nDer Preis für disen Tannenbaum beträgt {0},- Euro.\n\nVielen Dank für Ihren Einkauf.", preis);
            Console.Read();
        }
    }
}