using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items = new T[];
        public MyList()
        {
            items = new T[0];// diziyi 0 elemanlı yaptık
        }

        public void Add(T item)
        {
            items = new T[items.Length+1];
        }
    }
}
