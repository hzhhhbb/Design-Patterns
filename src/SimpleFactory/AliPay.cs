using System;

namespace SimpleFactory
{
    public class AliPay : AbstractPaymentMethod
    {
        public override bool IsAccountNormal(string accountNumber)
        {
            return true;
        }

        public override void NoticeUser(string message)
        {
            Console.WriteLine("支付宝支付");
            Console.WriteLine(message);
        }

    }
}
