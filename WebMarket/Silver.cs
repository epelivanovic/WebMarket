using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMarket
{
    class Silver :Card
    {
        public override Result CalculateDis(Card c, double purc)
        {
            ErrorMessage = "";
            try
            {
                c.DiscountRate = 0.02;
                if (c.Turnover > 300)
                {
                    c.DiscountRate = 0.035;
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
