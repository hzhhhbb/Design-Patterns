namespace SingletonPattern
{
    using System;
    using System.Threading;

    public class SingletonTest
    {
        private static SingletonTest instance = null;

        private static readonly object Locker = new object();

        private SingletonTest()
        {
            Thread.Sleep(1000);
            Console.WriteLine("******单例类被实例化******");
        }

        public static SingletonTest GetInstance()
        {
            // 双重锁定的方式实现单例模式
                if (instance == null)
                {
                    lock (Locker)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonTest();
                        }
                    }
                }

                return instance;
        }

        public void PrintSomething()
        {
            Console.WriteLine($"当前线程Id为{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Singleton Pattern Test");
        }
    }
}
