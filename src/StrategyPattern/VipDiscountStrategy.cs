using System;

namespace StrategyPattern
{
    public class VipDiscountStrategy:AbstractDiscountStrategy
    {
        public override decimal Discount(decimal amount)
        {
            return amount * 0.8M;
        }
    }
}
