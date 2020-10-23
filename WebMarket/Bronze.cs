using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMarket
{
    class Bronze:Card
    {
        public override Result CalculateDis(Card c, double purc)
        {
            try
            {
                ErrorMessage = "";
                c.DiscountRate = 0;
                if (c.Turnover >= 300)
                {
                    c.DiscountRate = 0.025;
                }
                else if ((c.Turnover >= 100) && (c.Turnover < 300))
                {
                    c.DiscountRate = 0.01;
                }
                Result r = new Result();

                r.DiscountRate = c.DiscountRate;
                r.Discount = purc * r.DiscountRate;
                r.Total = purc - r.Discount;
                return r;
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
                return null;
            }
        }

    }
}
