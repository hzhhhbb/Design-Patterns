using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract  class AbstractPaymentMethodFactory
    {
        public abstract AbstractPaymentMethod GetPaymentMethod();
    }
}
