using SalesWebMvcFrame70.Data;
using SalesWebMvcFrame70.Models;
using Microsoft.EntityFrameworkCore;

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

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
