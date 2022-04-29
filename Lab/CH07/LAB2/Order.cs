using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Order
    {
        private short _itemNumber;
        private byte _quantity;
        private byte _estimatedDeliveryDays;

        public Order(short itemNumber, byte quantity, byte estimatedDeliveryDays)
        {
            _itemNumber = itemNumber;
            _quantity = quantity;
            _estimatedDeliveryDays = estimatedDeliveryDays;

            if (itemNumber < 100 || itemNumber > 999)
            {
                throw new InvalidNumberException("Order is Invalid");
            }
           
            if(quantity < 1 || quantity > 12)
            {
                throw new InvalidQuantityException("Order is Invalid");
            }
           
            if (estimatedDeliveryDays < 1 || estimatedDeliveryDays > 30)
            {
                throw new InvalidDeliveryDaysException("Order is Invalid");
            }
         
        }
        public short ItemNumber { get { return _itemNumber; } set => value = ItemNumber; }
        public byte Quantity { get { return _quantity; } set => value = Quantity; }
        public byte EstimatedDeliveryDays { get { return _estimatedDeliveryDays; } set => value = EstimatedDeliveryDays; }
    }
}
