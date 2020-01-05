using StockAPI.Models.ApiDataModels;
using StockAPI.Data;
using StockAPI.Repositories.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Repositories
{
    public class StockRepository : BaseRepository, IStockRepository
    {
        public StockRepository(StockAPIContext context) : base(context)
        {

        }
        public async Task<IEnumerable<StockData>> ListAsync()
        {
            return await Task.Run(() => _context.StockData.ToList());
        }
        public async Task AddAsync(StockData stockData)
        {
            await _context.StockData.AddAsync(stockData);
        }

        public async Task<StockData> FindBySymbolAsync(string Symbol)
        {
            var ID = _context.StockData.Select(s => s.ID).Single();
            var quote = _context.Quote.First(s => s.Symbol == Symbol);
            var chart = _context.Chart.Where(s => s.StockDataID == ID).ToList();

            var stockData = new StockData
            {
                ID = ID,
                Quote = quote,
                Chart = chart,
            };

            return await Task.Run(() => stockData);
        }

        public void Remove(StockData stockData)
        {
            _context.StockData.Remove(stockData);
        }

        public bool IsDbEmpty()
        {
            return !_context.StockData.Any();
        }

        public bool SpecificStockDataExists(string Symbol)
        {
            return _context.StockData.Any(e => e.Quote.Symbol == Symbol || e.Quote.CompanyName.Contains(Symbol));
        }

        public int CountOfStockData()
        {
            return _context.StockData.ToList().Count();
        }
    }
}
