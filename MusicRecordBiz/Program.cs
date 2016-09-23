using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRecordBiz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            DateTime dat = DateTime.Now;
            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);

            Console.Write("\n1. Add a new record ");
            Console.Write("\n2. View an existing record ");
            Console.Write("\n3. Update a record ");
            Console.Write("\n4. Delete a record ");
            Console.Write("\n5. Do something magical here... ");

            Console.Write("\n\nPlease choose an option: ");
            string response = Console.ReadLine();

            string[,] recordDatabase = { 
                { "Michael Jackson", "Heal the World" },
                { "Enigma", "Rivers of Belief" }
            };
            switch (response)
            {
                case "1":
                    {
                        Console.WriteLine("Case 1");
                        HelloOne();
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Case 2");
                        HelloTwo();
                        foreach (string item in recordDatabase)
                        {
                            Console.Write("{0} \n", item);
                        }
                    }
                    break;

                case "3":
                    {
                        Console.WriteLine("Case 3");
                        HelloThree();
                    }
                    break;

                case "4":
                    {
                        Console.WriteLine("Case 4");
                        HelloFour();
                    }
                    break;

                case "5":
                    {
                        Console.WriteLine("Case 5");
                        HelloFive();
                    }
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.ReadLine();

        }

        private static void HelloOne()
        {
            Console.WriteLine("Hello you chose 1");

        }

        private static void HelloTwo()
        {
            Console.WriteLine("Hello you chose 2");
        }

        private static void HelloThree()
        {
            Console.WriteLine("Hello you chose 3");
        }

        private static void HelloFour()
        {
            Console.WriteLine("Hello you chose 4");
        }

        private static void HelloFive()
        {
            Console.WriteLine("Hello you chose 5 ");
        }

    }
}

