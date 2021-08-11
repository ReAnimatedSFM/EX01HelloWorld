using System;

namespace EX01HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string schoolName;
            string motto = "Fokuseret talent";

            schoolName = "AspIT - Nordjylland";

            Console.WriteLine($"{schoolName}, er en skole i Aalborg. Mottoet for skolen er: {motto}.");

            Console.ReadKey();
        }
    }
}
