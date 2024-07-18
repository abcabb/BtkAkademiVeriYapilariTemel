using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BtkAkademiVeriYapilariTemel
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Hashtable
            //Declaration
            var sehirler = new Hashtable();

            //Add
            sehirler.Add(17, "Çanakkale");
            sehirler.Add(34, "Istanbul");
            sehirler.Add(35, "Izmir");
            sehirler.Add(23, "Elazığ");

            //Travel
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            //Keys
            var anahtarlar = sehirler;
            Console.WriteLine("\nAnahtarlar: ");
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine(item.Key);
            }

            //Values

            Console.WriteLine("\nDeğerler: ");

            /*
            
            Hashtable degerler = sehirler;
            foreach(DictionaryEntry item in degerler)            ===> Bu, bir yol. Bütün hash table'ı alıp foreach'de values seçmek.
            {
                Console.WriteLine(item.Value);
            }
            
            */

            /*
             
            var degerler = sehirler.Values;
            foreach (var item in degerler)                       ===> Bu, bir yol. Bütün var sayesinde Hashtable'ın sadece values kısmını almak. 
            {                                                   *Bir hashtable'a başka bir Hashtable'ın sadece değerlerini atamazsınç Çünkü Key değerleri de olmak zorunda.
                Console.WriteLine(item);
            }

            */

            ICollection degerler = sehirler.Values;
            foreach(var item in degerler)
            {
                Console.WriteLine(item);                        //Bu da olur. Neden ICollection interface'ini data type olarak kullandığımızı ileride çok daha iyi anlayacağız.
            }                                                   //Ama sanırım List<T>, Hashtable, ArrayList vs.. gibi Collection'ları aynı arayüzle yönetebilmemize yarıyor. 

            //Reach an element
            Console.WriteLine("\nElemana Erişme :");
            Console.WriteLine(sehirler[34]);

            //Delete an element
            Console.WriteLine("\nEleman Silme :");
            sehirler.Remove(23);
            foreach(DictionaryEntry item in sehirler)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            Console.ReadKey();
        }
    }
}
