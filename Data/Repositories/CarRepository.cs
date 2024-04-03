using Data.Interfaces;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _context;

        public CarRepository(ApplicationDbContext context) 
        { 
            _context = context;
        }

        public async Task<IEnumerable<CarInfo>> GetCars() 
        {
            var query =  (from c in _context.Cars
                         join q in _context.Quotes on c.CarId equals q.CarId into cq
                         from subq in cq.Where(x => x.IsCurrent).DefaultIfEmpty()
                         join b in _context.Buyers on subq.BuyerId equals b.BuyerId
                         join l in _context.Locations on c.LocationId equals l.LocationId
                         join sh in _context.StatusHistory on c.CarId equals sh.CarId into csh
                         from subsh in csh.OrderByDescending(sh => sh.StatusDate).ThenByDescending(sh => sh.StatusHistoryId).Take(1)
                         join s in _context.Statuses on subsh.StatusId equals s.StatusId
                         select new CarInfo
                         {
                             Year = c.Year,
                             Make = c.Make,
                             Model = c.Model,
                             SubModel = c.Submodel,
                             BuyerName = b.Name,
                             QuoteAmount = subq.Amount,
                             StatusName = s.Name,
                             StatusDate = subsh.StatusDate,
                             ZipCode = l.ZipCode
                         }).ToListAsync();


            return await query; 
        }

        public async Task<IEnumerable<CarInfo>> GetCarInfo()
        {
            var carinfo = _context.GetCarInfo();
            return await carinfo;
        }
    }
}
