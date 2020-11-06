namespace AbstractFactoryPattern
{
    public class PaymentMethodFactory : AbstractPaymentMethodFactory
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
