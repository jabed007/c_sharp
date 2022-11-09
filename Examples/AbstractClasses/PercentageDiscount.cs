using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class PercentageDiscount : Discount
    {
        public override int AmountAfterDiscount(int totalAmount)
        {
            return (int)(totalAmount - (totalAmount * DiscountAmount) / 100.0);
        }

        public override int GetDiscountedAmount()
        {
            return base.GetDiscountedAmount();
        }
    }
}
