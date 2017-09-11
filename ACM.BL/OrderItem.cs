using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int _orderItemId)
        {
            this.OrderId = _orderItemId;
        }

        public int OrderId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        //  public Product ProductName { get; set; }

        public OrderItem Retrieve(int _orderItemId)
        {
            return new OrderItem(_orderItemId);
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();

        }

        public bool Validate()
        {
            var isValid = true;
            if (ProductId <= 0) isValid = false;
            if (OrderQuantity <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            return true;
        }

    }
}
