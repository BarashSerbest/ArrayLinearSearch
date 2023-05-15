using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Dizinin boyutunu ve elemanlarını kullanıcıdan alma
        Console.Write("Dizinin boyutunu girin: ");
        int boyut = int.Parse(Console.ReadLine());

        var dizi = new int[boyut];

        Console.WriteLine("Dizinin elemanlarını girin:");
        for (int i = 0; i < boyut; i++)
        {
            Console.Write($"{i + 1}. Eleman: ");
            int eleman = int.Parse(Console.ReadLine());
            dizi[i] = eleman;
        }

        // Dizide aranacak olan elemanı kullanıcıdan alma
        Console.Write("Aranacak elemanı girin: ");
        int arananEleman = int.Parse(Console.ReadLine());

        // Aranılan elemanın dizide olup olmadığını Linear Search fonksiyonu kullanarak bulma 
        bool sonuc = LinearSearch(dizi, arananEleman);

        if (sonuc)
            Console.WriteLine($"Dizi içerisinde aradığınız eleman bulundu. Girdiğiniz eleman: {arananEleman}");
        else
            Console.WriteLine($"Dizi içerisinde aradığınız eleman bulunamadı. Girdiğiniz eleman: {arananEleman}");

        Console.ReadLine();
    }

    static bool LinearSearch(int[] dizi, int arananEleman)
    {
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] == arananEleman)
                return true;
        }

        return false;
    }
}
