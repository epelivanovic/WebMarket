using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMarket
{
   public abstract class Card
    {
        private string owner;
        private double turnover;
        private double discrate;
        private string errormessage;
        public string ErrorMessage
        {
            get
            {
                return errormessage;
            }
            set
            {
                errormessage = value;
            }
        }
        public  string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }
        public  double Turnover
        {
            get
            {
                return turnover;
            }
            set
            {
                turnover = value;
            }
        }
        public  double DiscountRate
        {
            get
            {
                return discrate;
            }
            set
            {
                discrate = value;
            }
        }
        public virtual Result CalculateDis(Card c, double purc)
        {
            Result r = new Result();
            
            r.DiscountRate = c.DiscountRate;
            r.Discount = purc * r.DiscountRate;
            r.Total = purc - r.Discount;
            return r;
        }
    }
}
