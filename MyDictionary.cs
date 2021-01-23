using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K, V>
    {
        K[] index;
        V[] names;

        K[] indexTemp;
        V[] namesTemp;

        public MyDictionary()
        {
            names = new V[0];
            index = new K[0];
        }
        public void Add(K key, V value)
        {
            namesTemp = names;
            indexTemp = index;

            names = new V[names.Length + 1];
            index = new K[index.Length + 1];

            for (int i = 0; i < namesTemp.Length; i++)
            {
                names[i] = namesTemp[i];
            }

            names[names.Length - 1] = value;

            for (int j = 0; j < indexTemp.Length; j++)
            {
                index[j] = indexTemp[j];
            }

            index[index.Length - 1] = key;

            Console.WriteLine(value + " Başarıyla eklendi.");
            DisplayItems(index,names);
        }

        public void DisplayItems(K[] index, V[] names)
        {
            Console.WriteLine("----------- Tüm Liste----------------");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("ID: "+ index[i]+" İsim: "+names[i]);
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
