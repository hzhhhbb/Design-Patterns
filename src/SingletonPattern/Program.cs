namespace SingletonPattern
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            //// 类的构造函数为私有，不能直接实例化
            //// SingletonTest singleton = new SingletonTest();
            //
            // 单线程情况
            SingletonTest2 singleton = SingletonTest2.GetInstance();
            singleton.PrintSomething();
            
            // 多线程情况
            for (int i = 0; i < 10; i++)
            {
                Task.Run(
                    () =>
                        {
                            SingletonTest2 singleton1 = SingletonTest2.GetInstance();
                            singleton1.PrintSomething();
                        });
            }

            // 单线程情况
            SingletonTest2 singleton2 = SingletonTest2.GetInstance();
            singleton2.PrintSomething();

            // 反射破坏单例
            var singletonInstance = System.Activator.CreateInstance(typeof(SingletonTest2), true);

            Console.ReadKey();
        }
    }
}
