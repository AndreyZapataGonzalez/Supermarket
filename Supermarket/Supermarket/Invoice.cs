using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Invoice : Ipay
    {
        private List<Product> _products;

        private string items { get; set; }

        public Invoice()
        {
            _products = new List<Product>();
        }

        public  Product AddProduct(Product product)
        {
            _products.Add(product);
            return product;
        }

        public decimal ValueToPay()
        {
            decimal full_value =0;
            foreach (Product product in _products)
            {
                full_value += product.ValueToPay();  
            }
            return full_value;
        }


        public override string ToString()
        {
            foreach (Product product in _products)
            {
                items = product.ToString();
            }

            return $"{items}" +
                "\n\t" +               "==============" +
                $"\n\tTOTAL:         {$"{ValueToPay():C2}",12}";
                
        }

        
    }
}
