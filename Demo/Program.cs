using System;
using Task1;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<string>();

            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");

            list.AddAt(2, "A");

            list.Print();
        }
    }
}
