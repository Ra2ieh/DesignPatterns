using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator;

public class SpecialOffer : Decorator
{
    public SpecialOffer(Vehicle vehicle) : base(vehicle)
    {
    }
    public int DiscountPercentage { get; set; }
    public string Offer { get; set; }
    public double Price
    {
        get
        {
            double price = base.Price;
            int percentage = 100 - DiscountPercentage;
            return Math.Round((price * percentage) / 100, 2);
        }
    }
}
