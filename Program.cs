using System;

public class Program
{
    static void Main(string[] args)
    {
        var k = (char)Console.Read();
        if (char.IsDigit(k))
        {
            Console.WriteLine("Rakamdır!");
        }
        else if (char.IsLower(k))
        {
            Console.WriteLine("Kucuk karakter.");
        }
        else if(char.IsUpper(k))
        {
            Console.WriteLine("Buyuk karakter.");
        }
        else
        {
            Console.WriteLine("Bilinmeyen karakter.");
        }

        Console.WriteLine(k);
        Console.ReadKey();

        static void TekMiCiftMiOrnek()
        {
            // tek / cift
            Console.WriteLine("Bir sayi giriniz: ");

            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} tek bir sayıdır.");
            }
        }

        static void MutlakDegerOrnek()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($" |{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }
    }
}