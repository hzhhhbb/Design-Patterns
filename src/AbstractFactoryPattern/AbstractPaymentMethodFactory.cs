namespace AbstractFactoryPattern
{
    public abstract class AbstractPaymentMethodFactory
    {
        public abstract IAliPay GetAliPay();

        public abstract IWeiXinPay GetWeiXinPay();
    }
}
