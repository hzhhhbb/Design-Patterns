namespace SimpleFactory
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            AbstractPaymentMethod aliPay = PaymentMethodFactory.GetPaymentMethod(PaymentMethodEnum.AliPay);
            AbstractPaymentMethod weiXinPay = PaymentMethodFactory.GetPaymentMethod(PaymentMethodEnum.WeiXinPay);
            aliPay.Pay("Vincent", 700M);
            Console.WriteLine("*********************************");
            weiXinPay.Pay("123456", 1000M);
            Console.ReadKey();
        }
    }
}
