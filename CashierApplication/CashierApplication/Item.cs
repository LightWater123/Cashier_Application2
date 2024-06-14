using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;
        
        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public double getTotalPrice(int price, int quantity )
        {

            int total = price * quantity;
            double total_price = total;

            return total_price;
        }

    }

    class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = discount;

            // calling out this method to calculate the discounted price in the main class
            discountedPrice();
            
        }

        private void discountedPrice()
        {
            discounted_price = item_price * (1 - item_discount * 0.01);
        }

        public double getTotalPrice()
        {
            return discounted_price * item_quantity;
        }

        public void setPayment(double payment)
        {
            this.payment_amount = payment;
            this.change = payment - getTotalPrice();

        }

        public double getChange()
        {
            return change;
        }
    }
}
