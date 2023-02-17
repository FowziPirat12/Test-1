using System;
namespace Test1
{
    class progeam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ner två heltal! (bredd och höjd)");
            int heltal1 = int.Parse(Console.ReadLine());
            int heltal2 = int.Parse(Console.ReadLine());
            AREA (heltal1, heltal2);
            Console.WriteLine($"Arean blir:{heltal1 * heltal2} cm^2");


        }

        static int AREA(int heltal1, int heltal2)
        {
            return (heltal1 * heltal2);
        }
    }
}