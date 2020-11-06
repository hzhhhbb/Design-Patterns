namespace FactoryMethodPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            AbstractPaymentMethod aliPay = new AliPayFactory().GetPaymentMethod();
            AbstractPaymentMethod weiXinPay = new WeiXinPayFactory().GetPaymentMethod();
            aliPay.Pay("Vincent", 700M);
            Console.WriteLine("*********************************");
            weiXinPay.Pay("123456", 1000M);
            Console.ReadKey();
        }
    }
}
