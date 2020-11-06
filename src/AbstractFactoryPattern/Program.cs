namespace AbstractFactoryPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PaymentMethodFactory();
            IAliPay aliPay = factory.GetAliPay();
            IWeiXinPay weiXinPay = factory.GetWeiXinPay();

            var factory1 = new PaymentMethodFactory1();
            IAliPay aliPay1 = factory1.GetAliPay();
            IWeiXinPay weiXinPay1 = factory1.GetWeiXinPay();

            Console.ReadKey();
        }
    }
}
