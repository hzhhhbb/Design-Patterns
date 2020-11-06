namespace AbstractFactoryPattern
{
    using System;

    public class AliPay : IAliPay
    {
        public bool IsAccountNormal(string accountNumber)
        {
            return true;
        }

        public  void NoticeUser(string message)
        {
            Console.WriteLine("支付宝支付");
            Console.WriteLine(message);
        }
    }
}
