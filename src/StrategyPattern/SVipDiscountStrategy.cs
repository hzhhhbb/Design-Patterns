using System;

namespace StrategyPattern
{
    public class SVipDiscountStrategy:AbstractDiscountStrategy
    {
        public override decimal Discount(decimal amount)
        {
            return amount * 0.7M;
        }
    }
}
