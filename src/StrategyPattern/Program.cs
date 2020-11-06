namespace StrategyPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入客户类型（vip，svip）：");
            string customer = Console.ReadLine();

            StrategyContext context;
           
            decimal amount = 100M;
            if (customer == "vip")
            {
                context = new StrategyContext(new VipDiscountStrategy());
                amount = context.ExecuteStrategy(amount);
            }
            else if (customer == "svip")
            {
                context = new StrategyContext(new SVipDiscountStrategy());
                amount = context.ExecuteStrategy(amount);
            }
            Console.WriteLine(amount);
            Console.ReadKey();

        }
    }
}
