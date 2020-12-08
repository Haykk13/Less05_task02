using System;

namespace Less05_task02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            Console.WriteLine(instance[6]);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public int this[int index]
        {
            get
            {
                return array[index];
            }
        }
    }
}
