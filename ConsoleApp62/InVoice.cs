using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    public class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        private string article;
        private int quantity;
        private decimal price;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public decimal CostCalculation(bool needEdv)
        {
            if (needEdv == true)
            {
                return (Price * Quantity) * 1.18m;
            }
            else
            {
                return Price * Quantity;
            }
        }
    }

}
