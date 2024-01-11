using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sırayla 20 adet pozitif tam sayı giriniz: ");

            int[] myNumbers = new int[20];// tek tek alacağımız sayılar için
            int[] maxThree = new int[3];// istemler arasında → girilen sayılardan en büyük üçü için
            int[] minThree = new int[3];// istemler arasında → girilen sayılardan en küçük üçü için
            int maxTotal = 0;// istemler arasında → en büyük üç sayının toplamı için
            int minTotal = 0;// istemler arasında → en küçük üç sayının toplamı için

            for (int i = 0; i < 20; i++)        // 0-20 → 20 kere çalıştır.
            {
                while(true)
                {
                    try
                    {
                        Console.Write((i + 1) + ". sayıyı giriniz:");// sayıları sırayla tek tek almak için
                        myNumbers[i] = int.Parse(Console.ReadLine());// parse ederek sayıları tek tek 20'lik diziye yolla
                        break;
                    }
                    catch (FormatException e) // Bir bağımsız değişkenin biçimi geçersiz olduğunda oluşturulan özel durum.
                    {
                        Console.WriteLine("Lütfen sayı değeri giriniz!");
                    }
                }
            }
            Array.Sort(myNumbers);//  küçükten büyüğe doğru sıralandı.
            
            foreach (var item in myNumbers)
            {
                Console.Write(item + " ");
            }
            
            for (int i = 0; i < 3; i++)
            {
                maxThree[i] = myNumbers[(myNumbers.Length - 3) + i];
                minThree[i] = myNumbers[i];
            }

            //  maxThree
            Console.Write("\nListedeki En Büyük Üç Sayı : ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(maxThree[i] + " ");
            }
            //  minThree
            Console.Write("\nListedeki En Küçük Üç Sayı : ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(minThree[i] + " ");
            }

            //  en büyük üç sayının toplamı
            for (int i = myNumbers.Length - 1; i > myNumbers.Length - 1 - 3; i--)
            {   //  i = myNumbers.Length - 1        →   Array.Sort  →   dizinin en sonundaki eleman ile başlamak 
                maxTotal += (int)myNumbers[i]; //  i > myNumbers.Length - 1 - 3    →   Array.Sort  →   sadece son üç eleman.
            }
            //  en küçük üç sayının toplamı
            for (int i = 0; i < 3; i++) // 0-3 → 3 kere çalıştır.
            {
                minTotal += (int)myNumbers[i];
            }
            Console.WriteLine("\nListedeki En Büyük Üç Sayının Ortalaması: " + maxTotal / 3);
            Console.WriteLine("Listedeki En Küçük Üç Sayının Ortalaması: " + minTotal / 3);
            Console.WriteLine("İki Listenin Ortalama Toplamları: " + (maxTotal + minTotal)/3);
        }
    }
}
