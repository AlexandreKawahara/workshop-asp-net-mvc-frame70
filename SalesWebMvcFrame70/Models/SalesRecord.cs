using SalesWebMvcFrame70.Models.Enums;

namespace SalesWebMvcFrame70.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public Double Amount{ get; set; }
        public SaleStatus Status{ get; set; }
        public Seller Seller{ get; set; }

        public SalesRecord()
        {
        }
        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
