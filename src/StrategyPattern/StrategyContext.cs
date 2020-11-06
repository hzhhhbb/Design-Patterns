using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class StrategyContext
    {
        private AbstractDiscountStrategy discountStrategy;

        public StrategyContext(AbstractDiscountStrategy concreteDiscountStrategy)
        {
            this.discountStrategy = concreteDiscountStrategy;
        }

        public decimal ExecuteStrategy(decimal amount)
        {
            return this.discountStrategy.Discount(amount);
        }
    }
}
