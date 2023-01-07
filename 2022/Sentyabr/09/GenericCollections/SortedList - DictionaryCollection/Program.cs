using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedList___DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary Generic Collection
            //Generic collection deyil
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "Salam");
            hashTable.Add(2, "Sagol");
            //hashTable.Add(2, "necesen");

            //Dictionary<TKey, TValue> T tipinde Key ve Value
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            dictionary1.Add(1, "Salam");
            dictionary1.Add(2, "Sagol");
            dictionary1.Add(3, "necesen");
            //dictionary1.Add(3, "yaxsiyam");

            Dictionary<bool, char> dictionary2 = new Dictionary<bool, char>();
            dictionary2.Add(true, 'A');

            Dictionary<decimal, long> dictionary3 = new Dictionary<decimal, long>();
            dictionary3.Add(20.2M, 156156165156156);


            bool delResult = dictionary1.Remove(2);

            if (delResult)
                Console.WriteLine("Deyer silindi!");
            else
                Console.WriteLine("Deyer collection'da tapilmadi!");


            hashTable[0] = 100;
            dictionary1[0] = "changed value";

            bool key100 = dictionary1.ContainsKey(100);
            if (key100)
            {
                var test = dictionary1[100];
            }
            else
            {
                Console.WriteLine("100-cu index movcud deyil!");
            }

            bool valHello = dictionary1.ContainsValue("Salam");

            if (valHello)
                Console.WriteLine("Salam deyeri tapildi!");
            else
                Console.WriteLine("Salam deyeri tapilmadi!");



            foreach (KeyValuePair<int, string> item in dictionary1)
            {
                Console.WriteLine("Acar: {0} || Deyer: {1}", item.Key, item.Value);
            }
            #endregion




            #region SortedList & SortedDictionary Generic Collections
            SortedList<int, string> sortedListCollection = new SortedList<int, string>();
            sortedListCollection.Add(10, "salam");
            sortedListCollection.Add(5, "sagol");
            sortedListCollection.Add(3, "necesen");
            sortedListCollection.Add(18, "yaxsiyam");

            SortedDictionary<int, string> sortedDictionaryCollection = new SortedDictionary<int, string>();
            sortedDictionaryCollection.Add(30, "salam");
            sortedDictionaryCollection.Add(53, "sagol");
            sortedDictionaryCollection.Add(42, "necesen");
            sortedDictionaryCollection.Add(79, "yaxsiyam");
            #endregion
        }
    }
}
