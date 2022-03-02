using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class VariablePriceProduct : Product

    {
        public float Quantity { get; set; }

        public string Measurement { get; set; }


        public override decimal ValueToPay()
        {
            decimal aux;
            aux = (Price * (decimal)Quantity);
            return (aux * (decimal)Tax) + aux;

        }

        public override string ToString()
        {
            return $"{Id}    {Description}" +
                $"\n\tMeasurement...:{$"{Measurement}",4}" +
                $"\n\tQuantity......:{$"{Quantity:N2}",12}" +
                $"\n\tPrice.........:{$"{Price:C2}",12}" +
                $"\n\tTax...........:  {$"{Tax:P2}",12}" +
                $"\n\tValue.........:{$"{ValueToPay():C2}",12}";
        }
    }
}
