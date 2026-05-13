using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Admin
{
    internal class Price_Item_Value
    {
        public String price, itemname, discount_amount;
        // codes fro setting the value of the item name and item price, which ware to be stored inside itenName and price variables
        public void setPriceItemValue(String item_name, String item_price)
        {
            this.itemname = item_name;
            this.price = item_price;
        }
        public String GetItemName()
        {
            return itemname;
        }
        public String GetPrice()
        {
            return price;
        }
        public void setPriceDiscountAmountValue(String discount_amount, string priceItem)
        {
            this.price = priceItem;
            this.discount_amount = discount_amount;
        }
        public String GetPriceItem()
        {
            return price;
        }
        public String GetDiscountAmount()
        {
            return discount_amount;
        }
    }
}
