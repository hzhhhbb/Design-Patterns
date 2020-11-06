namespace SingletonPattern
{
    using System;
    using System.Threading;

    public class SingletonTest2
    {
        // 静态变量的方式实现单例模式
        private static readonly Lazy<SingletonTest2> Instance = new Lazy<SingletonTest2>(() => new SingletonTest2());

        private static bool isInstantiated;

        private SingletonTest2()
        {
            if (isInstantiated)
            {
                throw new Exception("已经被实例化了，不能再次实例化");
            }

            isInstantiated = true;
            Thread.Sleep(1000);
            Console.WriteLine("******单例类被实例化******");
        }

        public static SingletonTest2 GetInstance()
        {
            return Instance.Value;
        }

        public void PrintSomething()
        {
            Console.WriteLine($"当前线程Id为{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Singleton Pattern Test");
        }
    }
}
