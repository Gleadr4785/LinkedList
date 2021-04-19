using System;

namespace LinkedList
{
    internal class LinkedList<T> where T: IComparable
    {
        private Item<T> head;

        public LinkedList()
        {
            head = null;
        }

        public void SetToEnd(T _item)
        {
            if (Empty())
            {
                head = new Item<T>(_item);
            }
            else
            {
                Item<T> temp1 = head;
                Item<T> temp2 = null;

                while (temp1 != null)
                {
                    temp2 = temp1;
                    temp1 = temp1.GetNext();
                }
                temp2.SetNext(new Item<T>(_item));
            }
        }

        public bool Contain(T _item)
        {
            Item<T> i = head;

            while (i != null && !i.GetNext().Equals(_item))
            {
                i = i.GetNext();
            }
            return i != null;
        }

        public bool Empty() => head == null;

        public void Sort()
        {
            if (Empty())
            {
                return;
            }

            Item<T> i,q,r;
            i = head;
            while(i.GetNext() != null)
            {
                q = i.GetNext();
                r = q;
                while(q != null)
                {
                    if(q.GetData().CompareTo(r.GetData()) <= 0){
                        r = q;
                    }
                    q = q.GetNext();
                }

                T temp = r.GetData();
                r.SetData(i.GetData());
                i.SetData(temp);
                i = i.GetNext();
            }

        }

        public void Print()
        {
            Item<T> i = head;

            while(i != null)
            {
                Console.WriteLine(i.GetData() + " ");
                i = i.GetNext();
            }
        }

        public void DeleteItems() => head = null;
    }
}