using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Item<T>
    {
        private T data;
        private Item<T> next;


        public Item(T _data)
        {
            SetData(_data);
            next = null;
        }

        public T GetData()
        {
            return data;
        }

        public void SetData(T _data)
        {
            data = _data;
        }

        public Item<T> GetNext()
        {
            return next;
        }

        public void SetNext(Item<T> p)
        {
            next = p;
        }
    }
}
