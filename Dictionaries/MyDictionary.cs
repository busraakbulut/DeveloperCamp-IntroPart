using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;
        
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                tempKeys[i] = keys[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                tempValues[i] = values[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
            Console.WriteLine("key: " + key+ "value:"+value);
        }
        public int KeyLength
        {
            get { return keys.Length; }
        }
        public int ValueLength
        {
            get { return values.Length; }
        }
        public K[] Key
        {
            get { return keys; }
        }
        public V[] Value
        {
            get { return values; }
        }

    }
}
