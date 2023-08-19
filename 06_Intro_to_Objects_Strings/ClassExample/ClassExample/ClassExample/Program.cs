using System;

namespace ClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet primrose = new Pet();
            primrose.name = "Primrose";
            primrose.age = 10;
            primrose.type = "chief cat";

            Pet gabe = new Pet();
            gabe.name = "Gabe";
            gabe.age = 11;
            gabe.type = "cat";

            Pet penny = new Pet();
            penny.name = "Penny";
            penny.age = 13;
            penny.type = "cat";

            Console.WriteLine(primrose.ToString ());
            Console.WriteLine( gabe.ToString ());
            Console.WriteLine( penny.ToString ());
        }
    }
}
