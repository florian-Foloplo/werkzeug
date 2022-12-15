using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimativeWerkzeugListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration 
            string[] name = new string [1000];
            string[] anzahl= new string[1000];
            string[] preis= new string[1000];
            string[] gesamtpreis= new string[1000];

            bool menue = true;

            //Menü der Werkzeugliste

            while(menue)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("\t\t Werkzeugtabelle");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("\n--> (0) Name der Werkzeuge");
                Console.WriteLine("--> (1) Anzahl der Werkzeuge");
                Console.WriteLine("--> (2) Einzelpreis vom Werkzeug");
                Console.WriteLine("--> (3) Übersicht und Gesamtpreis");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Wählen sie einen Menüpunkt aus mit eingabe der Zahl");
                string eingabe = Console.ReadLine();

                switch(eingabe)
                {
                    //Namen der Werkzeuge
                    case "0":
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Name der Werkzeuge");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Geben sie die Namen der Werkzeuge mit komma getrennt ein");
                        name = Console.ReadLine().Split(',');

                        Console.WriteLine(name[0] + name[1] + name[2] + name[3]);
                        Console.ReadKey();  
                        break;

                     //Anzahl der Werkzeuge
                     case"1":
                        Console.Clear();
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Anzahl der Werkzeuge");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Geben sie die anzahl der Werkzeuge ein und trennen sie sie mit einem Komma");
                        anzahl = Console.ReadLine().Split(',');

                        Console.WriteLine(name[0] + anzahl[10]);

                        Console.ReadKey();



                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
