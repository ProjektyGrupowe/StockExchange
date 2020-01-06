using AutoMapper;
using StockAPI.Models.ApiDataModels;
using StockAPI.Models.UserModels;
using StockAPI.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<StockData, StockResource>();
            CreateMap<Quote, QuoteResource>();
            CreateMap<QuoteResource, SaveQuoteResource>();
            CreateMap<Chart, ChartResource>();
            CreateMap<ChartResource, SaveChartResource>();
            CreateMap<User, UserResource>();
            CreateMap<Task<IList<User>>, Task<IList<UserResource>>>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}
