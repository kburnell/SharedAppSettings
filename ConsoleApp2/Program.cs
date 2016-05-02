using System;
using System.Configuration;

namespace ConsoleApp2 {

    internal class Program {

        private static void Main(string[] args) {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("SharedValue1"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("SharedValue2"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("ValueFromAppConfig"));
            Console.ReadKey();
        }

    }

}