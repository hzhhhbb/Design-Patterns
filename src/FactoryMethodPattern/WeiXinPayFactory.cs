namespace FactoryMethodPattern
{
    public class WeiXinPayFactory : AbstractPaymentMethodFactory
    {
        public override AbstractPaymentMethod GetPaymentMethod()
        {
            return new WeiXinPay();
        }
    }
}
