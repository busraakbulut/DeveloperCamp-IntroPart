using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int , string> dict = new MyDictionary<int, string>();
            dict.Add(1 , "Büşra");
            Console.WriteLine(dict.KeyLength);
            Console.WriteLine(dict.ValueLength);
            dict.Add(2, "Pelin");
            Console.WriteLine(dict.KeyLength);
            Console.WriteLine(dict.ValueLength);
        }
    }

    
}

