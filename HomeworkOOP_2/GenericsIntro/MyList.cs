using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        //MyList<T> -- MyList'te "T" ile çalışacağım.

        T[] items;
        //Constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Referans numarası kaybolmasın diye geçici bir dizi tanımlanıp items dizisinin referans adresi buraya atanır. Böylelikle items dizindeki elemanlar kaybolmaz.
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                // Geçici dizideki elemanları geri alma
            }

            items[items.Length - 1] = item;
        }
    }
}
