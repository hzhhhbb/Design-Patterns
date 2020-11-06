namespace AbstractFactoryPattern
{
    public class PaymentMethodFactory1 : AbstractPaymentMethodFactory
    {
        public override IAliPay GetAliPay()
        {
            return new AliPay();
        }

        public override IWeiXinPay GetWeiXinPay()
        {
            return new WeiXinPay();
        }
    }
}
