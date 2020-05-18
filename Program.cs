using System;

// Imports the library from the DLL.
using SellixIO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Makes the variable "api" a bridge that contacts Sellix's servers.
            Sellix api = new Sellix("api_key_here");

            // Prints the whole blacklist.
            Console.WriteLine(api.GetAllBlacklist());
        }
    }
}