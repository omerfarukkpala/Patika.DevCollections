using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static bool IsPrimeNumber(int sayi)// islemler arasında → asal olup olmadığını işaretlemek için
        {
            if (sayi <= 1) // asal sayılar ikiden başlar en küçük asal sayı 2 dir.
                return false;

            for (int i = 2; i < sayi - 1 ; i++)      
                if (sayi % i == 0)
                    return false;

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sırayla 20 adet pozitif tam sayı giriniz: ");
            
            ArrayList primeNumbers = new ArrayList();//  asal olanlar için
            ArrayList notPrimeNumbers = new ArrayList();//  asal olmayanlar için
            int myNumbers = 0; // tek tek alacağımız sayılar için
            int primeTotal = 0;// istemler arasında → asal sayıların toplamı için
            int notPrimeTotal = 0;// istemler arasında → asal olmayan sayıların toplamı için

            for (int i = 0; i < 20; i++)// 0-20 → 20 kere çalıştır.
            {
                while (true)// negatif ve numeric olmayan sayıların girilme ihtimaline karşı
                {           // elimizde pozitif tam sayı haricinde bir şey olursa yapmaya çalıştığımız şey bozulur
                    try
                    {
                        Console.Write((i + 1) + ". sayıyı giriniz:");// sayıları sırayla tek tek almak için
                        myNumbers = int.Parse(Console.ReadLine());// parse edildi.

                        if (myNumbers < 0)// eğer negatif bir sayı girişi yapılırsa
                        {
                            Console.WriteLine("Lütfen negatif olmayan bir sayı giriniz!");
                        }                                 
                        else
                        {
                            break;
                        }   
                    }
                    catch (FormatException e) // Bir bağımsız değişkenin biçimi geçersiz olduğunda oluşturulan özel durum.
                    {
                        Console.WriteLine("Lütfen sayı değeri giriniz!");
                    }
                }

                if (IsPrimeNumber(myNumbers)) // girilen sayılar asal ise asal toplamına eklemek için
                {
                    primeNumbers.Add(myNumbers);
                    primeTotal += myNumbers;
                }
                else // girilen sayılar asal değilse asal olmayan toplamına eklemek için
                {
                    notPrimeNumbers.Add(myNumbers);
                    notPrimeTotal += myNumbers;
                }
            }
            
            // Sıralama
            primeNumbers.Sort();// önce küçükten büyüğe doğru sıralandı.
            primeNumbers.Reverse();// sonra tersi alındı.

            notPrimeNumbers.Sort();
            notPrimeNumbers.Reverse();

            // Listeler
            Console.WriteLine("\nAsal Sayıların Listesi");// \n → satır geçmek için
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.Write(primeNumbers[i] + " ");// aynı satıra aralarında boşluk bırakarak bütün index'leri tek tek yaz
            }
            Console.WriteLine("\n\nAsal Olmayan Sayıların Listesi");
            for (int i = 0; i < notPrimeNumbers.Count; i++)
            {
                Console.Write(notPrimeNumbers[i] + " ");// aynı satıra aralarında boşluk bırakarak bütün index'leri tek tek yaz
            }

            // Ortalamalar  → hiç asal sayı girmeme durumu
            //              → hiç asal olmayan sayı girmeme durumu
            try
            {
                Console.WriteLine("\n\nAsal Sayıların Ortalaması: " + primeTotal / primeNumbers.Count);
            }
            catch (DivideByZeroException e) // Bir integral veya değeri sıfıra bölme girişimi olduğunda oluşturulan özel durum Decimal.
            {
                Console.WriteLine("\n\nHerhangi bir asal sayı girmediniz!");
            }
            try
            {
                Console.WriteLine("\n\nAsal Olmayan Sayıların Ortalaması: " + notPrimeTotal / notPrimeNumbers.Count);
            }
            catch (DivideByZeroException e) // Bir integral veya değeri sıfıra bölme girişimi olduğunda oluşturulan özel durum Decimal.
            {
                Console.Write("\nGirdiğiniz bütün sayılar asaldı!");
            }
        }
    }
}
