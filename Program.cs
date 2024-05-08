using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Projekt_Stanowiska_kasowego_w_sklepie
{
    internal class Program
    {
        static Dictionary<string, (string, int)> users = new Dictionary<string, (string, int)>();
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Zarejestruj klienta");
                Console.WriteLine("2. Logowanie klienta");
                Console.WriteLine("3. Wyjście");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Register();
                        break;
                    case "2":
                        Login();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }

            }
             static void Register()
            {
                Console.WriteLine("Podaj nazwę użytkownika");
                string username = Console.ReadLine();
                Console.WriteLine("Podaj hasło");
                string password = Console.ReadLine();
                Console.WriteLine("Podaj numer pesel");
                int ID = Convert.ToInt32(Console.ReadLine());

                if (!users.ContainsKey(username))
                {
                    users.Add(username, (password, ID));
                    Console.WriteLine("Rejestracja pomyślna!");
                }
                else
                {
                    Console.WriteLine("Taki użytkownik już istnieje");
                }

            }     
        }
    }
}