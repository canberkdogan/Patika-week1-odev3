using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("bir sayi giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 10)
        {
            Console.WriteLine("girilen sayı ondan buyuktur");
        }
        else if (sayi < 10)
        {
            Console.WriteLine("girilen sayı ondan kucuktur");
        }

        else
        {
            Console.Write("girilen sayı ona esittir");
        }
        if (sayi % 2 == 0)
        {
            Console.Write("girilen sayi cifttir");
        }
        else
        {
            Console.Write("girilen sayi tektir");

        }
    }

}