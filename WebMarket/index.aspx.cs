using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebMarket
{
    public partial class index : System.Web.UI.Page
    {
        public double _purchase=0;
        public double _turnover=0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbxTurnover.Text == string.Empty)&&(tbxPurchase.Text == string.Empty))
                {
                    tbxTurnover.BackColor = Color.Red;
                    tbxPurchase.BackColor = Color.Red;
                    lblError.Text = "Insert purchase and turnover value";     
                    return;
                }
                else
                {
                    tbxTurnover.BackColor = Color.Transparent;
                    tbxPurchase.BackColor = Color.Transparent;
                    lblError.Text = "";
                }
                if (tbxTurnover.Text == string.Empty)
                {
                    tbxTurnover.BackColor = Color.Red;
                    lblError.Text = "Insert turnover value";
                    return;
                }
                else
                {
                    tbxTurnover.BackColor = Color.Transparent;
                    lblError.Text = "";
                }
                if (tbxPurchase.Text == string.Empty)
                {
                    tbxPurchase.BackColor = Color.Red;
                    lblError.Text = "Insert purchase value";
                    return;
                }
                else
                {
                    tbxPurchase.BackColor = Color.Transparent;
                    lblError.Text = "";
                }

                if (!double.TryParse(tbxPurchase.Text, out _purchase))
                {
                    lblError.Text = "Insert correct type of value";
                    tbxPurchase.BackColor = Color.Red;
                    return;
                }
                if (!double.TryParse(tbxTurnover.Text, out _turnover))
                {
                    lblError.Text = "Insert correct type of value";
                    tbxTurnover.BackColor = Color.Red;
                    return;
                }
                tbxTurnover.BackColor = Color.Transparent;
                tbxPurchase.BackColor = Color.Transparent;
                brPV.Text = _purchase.ToString() + "$";
                svPV.Text = _purchase.ToString() + "$";
                gPV.Text = _purchase.ToString() + "$";
                Result r = new Result();

                    Card s = new Silver();
                    Card b = new Bronze();
                    Card g = new Gold();
                    b.Turnover = _turnover;
                    s.Turnover = _turnover;
                    g.Turnover = _turnover;
                try
                {
                    r = b.CalculateDis(b, _purchase);
                }
                catch (Exception)
                {

                    lblError.Text=b.ErrorMessage;
                }
                    printBronze(r);
                try
                {
                    r = s.CalculateDis(s, _purchase);
                }
                catch (Exception)
                {

                    lblError.Text = s.ErrorMessage;
                }
                    printSilver(r);
                try
                {
                    r = g.CalculateDis(g, _purchase);
                }
                catch (Exception)
                {

                    lblError.Text = g.ErrorMessage;
                }
                    printGold(r); 
               
            }
            catch (Exception ex)
            {

                lblError.Text=ex.Message;
            }
        }
        public void printBronze(Result r)
        {

            try
            {
                r.Discount = Math.Round(r.Total, 2);
                r.Total = Math.Round(r.Discount, 2);
                brT.Text = r.Total.ToString() + "$";
                brD.Text = r.Discount.ToString() + "$";
                r.DiscountRate = r.DiscountRate * 100;
                
                brDR.Text = r.DiscountRate.ToString() + "%";
            }
            catch (Exception ex)
            {

                lblError.Text = ex.Message;
            }
        }
        public void printSilver(Result r)
        {

            try
            {
                r.Total = Math.Round(r.Total, 2);
                r.Discount = Math.Round(r.Discount, 2);
                svT.Text = r.Total.ToString() + "$";
                svD.Text = r.Discount.ToString() + "$";
                r.DiscountRate = r.DiscountRate * 100;
                svDR.Text = r.DiscountRate.ToString() + "%";
            }
            catch (Exception ex)
            {

                lblError.Text = ex.Message;
            }
        }
        public void printGold(Result r)
        {

            try
            {
                r.Total = Math.Round(r.Total, 2);
                r.Discount = Math.Round(r.Discount, 2);
                gT.Text = r.Total.ToString() + "$";
                gD.Text = r.Discount.ToString() + "$";
                r.DiscountRate = r.DiscountRate * 100;
                gDR.Text = r.DiscountRate.ToString() + "%";
            }
            catch (Exception ex)
            {

                lblError.Text = ex.Message;
            }
        }
    }
}