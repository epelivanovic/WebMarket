using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMarket
{
    class Gold:Card
    {
        public override Result CalculateDis(Card c, double purc)
        {
            ErrorMessage = "";
            try
            {
                c.DiscountRate = 0.02;
                int range = Convert.ToInt32(c.Turnover) / 100;
                switch (range)
                {
                    case 0: c.DiscountRate = 0.02; break;
                    case 1: c.DiscountRate += 0.01; break;
                    case 2: c.DiscountRate += 0.02; break;
                    case 3: c.DiscountRate += 0.03; break;
                    case 4: c.DiscountRate += 0.04; break;
                    case 5: c.DiscountRate += 0.05; break;
                    case 6: c.DiscountRate += 0.07; break;
                    default: c.DiscountRate += 0.08; break;
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
