namespace SimpleFactory
{
    using System;

    public class PaymentMethodFactory
    {
        public static AbstractPaymentMethod GetPaymentMethod(PaymentMethodEnum paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethodEnum.AliPay:
                    return new AliPay();
                case PaymentMethodEnum.WeiXinPay:
                    return new WeiXinPay();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
