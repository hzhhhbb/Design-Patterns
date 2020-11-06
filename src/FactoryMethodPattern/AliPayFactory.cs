namespace FactoryMethodPattern
{
    public class AliPayFactory : AbstractPaymentMethodFactory
    {
        public override AbstractPaymentMethod GetPaymentMethod()
        {
            return new AliPay();
        }
    }
}
