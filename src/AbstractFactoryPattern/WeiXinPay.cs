namespace AbstractFactoryPattern
{
    using System;

    public class WeiXinPay : IWeiXinPay
    {
        public  bool IsAccountNormal(string accountNumber)
        {
            return true;
        }

        public  void NoticeUser(string message)
        {
            Console.WriteLine("微信支付");
            Console.WriteLine(message);
        }
    }
}
