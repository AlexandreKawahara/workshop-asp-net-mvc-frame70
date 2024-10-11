using SalesWebMvcFrame70.Data;
using SalesWebMvcFrame70.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvcFrame70.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcFrame70Context _context;

        public SalesRecordService(SalesWebMvcFrame70Context context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                .Include(x => x.Seller)            /* join com a tabela seller.. Leitura deste trecho: x que leva em x.seller */
                .Include(x => x.Seller.Department) /* join com a tabela department.. Leitura deste trecho: x que leva em x.seller.department*/
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
