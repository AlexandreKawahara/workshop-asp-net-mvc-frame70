using SalesWebMvcFrame70.Data;
using SalesWebMvcFrame70.Models;

namespace SalesWebMvcFrame70.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcFrame70Context _context;

        public SellerService(SalesWebMvcFrame70Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
