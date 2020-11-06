using System;

namespace SimpleFactory
{
    public class WeiXinPay : AbstractPaymentMethod
    {
        public override bool IsAccountNormal(string accountNumber)
        {
            return true;
        }

        public override void NoticeUser(string message)
        {
            Console.WriteLine("微信支付");
            Console.WriteLine(message);
        }
    }
}
