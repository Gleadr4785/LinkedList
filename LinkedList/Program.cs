using System;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Item<string> ps = new Item<string>("seruuus");
            LinkedList<string> list = new LinkedList<string>();

            list.SetToEnd("ahojky");
            list.SetToEnd("čauky");
            list.Print();
            Console.WriteLine("-----------");
            list.Sort();
            list.Print();
            Console.WriteLine("-----------");
            list.DeleteItems();
            list.Print();
        }

        
    }
}
