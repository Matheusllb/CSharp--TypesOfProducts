using System.Globalization;

namespace TypesOfProducts.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; protected set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) " + "$ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
