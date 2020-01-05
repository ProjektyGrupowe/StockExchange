using StockAPI.Models;
using StockAPI.Models.ApiDataModels;
using StockAPI.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Services
{
    public interface IStockService
    {
        Task<IEnumerable<StockData>> ListAsync();
        Task<StockResponse> SaveAsync(StockData stockData);
        Task<StockData> FindBySymbolAsync(string Symbol);
        Task<StockResponse> DeleteAsync(string Symbol);
        int CountOfStockData();
        bool IsDbEmpty();
        bool SpecificStockDataExists(string Symbol);
    }
}
