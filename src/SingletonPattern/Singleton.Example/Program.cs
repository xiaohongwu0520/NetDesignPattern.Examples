using System;

namespace Singleton.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            EagerSingleton eSingleton1 = EagerSingleton.GetInstance();
            EagerSingleton eSingleton2 = EagerSingleton.GetInstance();
            if (eSingleton1 == eSingleton2)
            {
                Console.WriteLine("两个对象是相等实例");
            }

            LazySingleton lSingleton1 = LazySingleton.GetInstance();
            LazySingleton lSingleton2 = LazySingleton.GetInstance();
            if (lSingleton1 == lSingleton2)
            {
                Console.WriteLine("两个对象是相等实例");
            }
            Console.ReadLine();
        }
    }
}
