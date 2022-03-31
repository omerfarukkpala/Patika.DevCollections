using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        /*Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri
         bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız. */
        static bool IsVowel(char harf)//  istemler arasında → sesli mi değil mi?
        {
            string vowelList = "aeıioöuü";
            if (vowelList.Contains(harf))
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir cümle giriniz: ");
            string sentence = Console.ReadLine();
            List<char> vowelList = new List<char>();


            // Sesliyse Ekle
            foreach (char vowel in sentence)
                if (IsVowel(vowel)) vowelList.Add(vowel);


            // Sırala
            char[] vowels = vowelList.ToArray();
            Array.Sort(vowels);


            // Yazdır
            Console.WriteLine("\nCümlenin İçinde Bulunan Sesli Harfler");
            foreach (char vowel in vowels)
                Console.Write(vowel + " ");
        }
    }
}