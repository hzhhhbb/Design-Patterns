namespace StrategyPattern
{
    public abstract class AbstractDiscountStrategy
    {
        public abstract decimal Discount(decimal amount);
    }
}
