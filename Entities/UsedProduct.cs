using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Store.Entities
{
    class UsedProduct : Product
    {
        public DateTime Manufacture { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufacture) : base (name, price)
        {
            Manufacture = manufacture;
        }

        public override string PriceTag()
        {
            return Name + " (Used) " + " $ " + Price.ToString("f2", CultureInfo.InvariantCulture)
                + " (Manufacture date: " + Manufacture.ToString("dd/MM/yyyy") + ")";
        }
    }
}
