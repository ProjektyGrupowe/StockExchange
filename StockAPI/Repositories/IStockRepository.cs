﻿using StockAPI.Models.ApiDataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Repositories
{
    public interface IStockRepository
    {
        Task<IEnumerable<StockData>> ListAsync();
        Task AddAsync(StockData stockData);
        Task<StockData> FindBySymbolAsync(string Symbol);
        int CountOfStockData();
        void Remove(StockData stockData);
        bool IsDbEmpty();
        bool SpecificStockDataExists(string Symbol);
    }
}
