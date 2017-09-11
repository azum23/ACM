using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        { }

        public Product(int _productId)
        { this.ProductId = _productId; }

        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string _productName;

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set { _productName = value; }
        }

        public decimal? CurrentPrice { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return this.ToString();
        }

        public string Log()
        {
            return this.ProductId + " " +this.ProductName;
        }
    }
}
