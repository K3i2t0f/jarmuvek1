using System;

namespace BuszOOP
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Busz t1 = new Busz("Piros", 12);
            t1.Evjarat = 2010;
            System.Console.WriteLine(t1);
            System.Console.WriteLine(t1.Kor + " eves");
            System.Console.WriteLine(t1.Allapot);
            
        }
    }
}