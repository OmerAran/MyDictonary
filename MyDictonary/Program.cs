using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictonary<int, string> myDictonary = new MyDictonary<int, string>();
            myDictonary.Add(1, "A");
            myDictonary.Add(2, "B");
            myDictonary.Add(3, "C");
            myDictonary.Add(4, "D");
            myDictonary.Add(5, "E");
            myDictonary.Add(6, "F");
            myDictonary.Add(7, "G");
            myDictonary.Add(8, "H");
            myDictonary.Add(9, "I");

            myDictonary.Show();

        }
    }
}
