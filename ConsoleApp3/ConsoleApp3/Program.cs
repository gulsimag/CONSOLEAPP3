using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi,sayac=0;
            Console.WriteLine("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=sayi;i++)
            {
                if (sayi%i==0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                Console.WriteLine("Asal Sayı");
            }
            else
            {
                Console.WriteLine("Asal Sayı değil");
            }
        }
          
        
    }
}
