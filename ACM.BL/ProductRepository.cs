using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int _productId)
        {
            Product product = new Product(_productId);

            if (product.ProductId == 1)
            {
                product.ProductName = "Ball";
                product.ProductDescription = "Football";
                product.CurrentPrice = 10.5M;
            }

            return product;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();

        }


        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {

                }
                else
                {

                }
            }

            return success;
        }
    }
}
