using System;
namespace Donguler_ForEach
{
 class Program
 {
    public static void Main(string[] args)
    {
        // while
        Console.WriteLine("sayi giriniz");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while (sayac <= sayi)
        {
            toplam+= sayac;
            sayac ++;
        }

        Console.WriteLine(toplam/sayac);


        //forEach

        string[] arabalar = {"bmw", "nissan","audi","woksvagen","opel","tofas"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
 }   
}