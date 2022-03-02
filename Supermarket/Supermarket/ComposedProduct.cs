using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class ComposedProduct : Product
    {

        public ICollection Products { get; set;}
        public float Discount { get; set; }

        private string auxiliary { get; set; }

        public decimal value { get; set; }

        public override decimal ValueToPay()
        {
            
            foreach (Product product in Products)
            {
                float desc = 0;
                decimal aux;
                aux = product.ValueToPay();

                desc = (float)aux * Discount;
                value += aux - (decimal)desc;

            }
            return value;
        }

        public override string ToString()
        {
            foreach (Product productDiscount in Products)
            {
                auxiliary += productDiscount.Description + ",";
            }

            return $"{Id}    {Description}" +
                $"\n\tProducts......:{$"{auxiliary}",5}" +
                $"\n\tDiscount......:  {$"{Discount:P}",12}" +
                $"\n\tValue.........:{$"{ValueToPay():C2}",12}";
                
        }
    }
}
