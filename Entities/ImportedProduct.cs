using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Store.Entities
{
    class ImportedProduct : Product
    {
        public Double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;

        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("f2", CultureInfo.InvariantCulture)
                +  "(Customs fee: $ " + CustomsFee.ToString("f2", CultureInfo.InvariantCulture) + ")";

        }

       

    }   
}
