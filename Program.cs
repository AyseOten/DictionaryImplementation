using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(565, "Ayse");
            myDictionary.Add(495, "Tarik");
            myDictionary.Add(204, "Fatih");
        }
    }
}
