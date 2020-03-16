using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Program
    {
        static Automat automat = new Automat();
        static Cash cash = new Cash();


        static void Main(string[] args)
        {
            while (true)
            {
                bool Choose = true;
                do
                {
                    Console.Clear();

                    Console.WriteLine("Wellcome to the Free Automat everything is free!");
                    Console.WriteLine("================================================\n");

                    Console.WriteLine("Press the number for the thing you wanna like.\n");
                    Console.WriteLine("\t11 - Faxe Kondi");
                    Console.WriteLine("\t12 - Pepsi Max");
                    Console.WriteLine("\t13 - Fanta Orange");
                    Console.WriteLine("\n\t00122 - Admin");

                    Console.Write("\nYou chose: ");

                    switch (Console.ReadLine())
                    {
                        case "11":
                            Console.WriteLine();
                            if (automat.faxeKondi[9] == null)
                            {
                                Console.WriteLine("Sold out");
                            }
                            else
                            {
                                Console.WriteLine("You got your Faxe Kondi");
                            }
                            automat.BuyingFaxeKondi();
                            Choose = false;
                            break;
                        case "12":
                            Console.WriteLine();
                            if (automat.pepsiMax[9] == null)
                            {
                                Console.WriteLine("Sold out");
                            }
                            else
                            {
                                Console.WriteLine("You got your Pepsi Max");
                            }
                            automat.BuyingPepsiMax();
                            Choose = false;
                            break;
                        case "13":
                            Console.WriteLine();
                            if (automat.fantaOrange[9] == null)
                            {
                                Console.WriteLine("Sold out");
                            }
                            else
                            {
                                Console.WriteLine("You got your Pepsi Max");
                            }
                            automat.BuyingFantaOrange();
                            Choose = false;
                            break;
                        case "00122":
                            Admin();
                            break;
                    }
                } while (Choose);

                Console.ReadKey();
            }

        }

        public static void Admin()
        {
            bool admin = true;
            string password = "Kode1234!";

            Console.Clear();

            Console.Write("Type the password to admin: ");

            if (Console.ReadLine() == password)
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine("Press the number to fill the machine (Not numpad).\n");
                    Console.WriteLine("\t1 - Fill Faxe Kondi " + automat.FaxeKondiFilled());
                    Console.WriteLine("\t2 - Fill Pepsi Max " + automat.PepsiMaxFilled());
                    Console.WriteLine("\t3 - Fill Fanta Orange " + automat.FantaOrangeFilled());
                    Console.WriteLine("\n\tEnter - Done");

                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.D1:
                            automat.FillFaxeKondi();
                            break;
                        case ConsoleKey.D2:
                            automat.FillPepsiMax();
                            break;
                        case ConsoleKey.D3:
                            automat.FillFantaOrange();
                            break;
                        case ConsoleKey.Enter:
                            admin = false;
                            break;
                    }
                } while (admin);
            }
        }
    }
}
