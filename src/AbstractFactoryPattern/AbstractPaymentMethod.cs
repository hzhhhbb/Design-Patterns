namespace AbstractFactoryPattern
{
    using System;

    public abstract class AbstractPaymentMethod
    {
        /// <summary>
        /// 判断用户的账号是否正常
        /// </summary>
        /// <param name="accountNumber">账号</param>
        /// <returns>账号是否正常</returns>
        public abstract bool IsAccountNormal(string accountNumber);

        /// <summary>
        /// 通知用户
        /// </summary>
        /// <param name="message">通知内容</param>
        public abstract void NoticeUser(string message);

        /// <summary>
        /// 支付过程
        /// </summary>
        /// <param name="accountNumber">用户账号</param>
        /// <param name="amount">金额</param>
        public virtual void Pay(string accountNumber, decimal amount)
        {
            if (this.IsAccountNormal(accountNumber))
            {
                Console.WriteLine($"账号：{accountNumber}已支付{amount}元");
                this.NoticeUser($"尊敬的{accountNumber}，您已成功支付{amount}元");
            }
        }
    }
}