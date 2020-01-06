using AutoMapper;
using StockAPI.Models.ApiDataModels;
using StockAPI.Resources;
using StockAPI.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveStockResource, StockData>().ForMember(x => x.ID, opt => opt.Ignore());
            CreateMap<SaveQuoteResource, Quote>();
            CreateMap<SaveChartResource, Chart>();
            CreateMap<UserResource, User>();
            CreateMap<Task<IList<UserResource>>, Task<IList<User>>>();
            CreateMap<User, RegisterModel>();
            CreateMap<User, UpdateModel>();
        }
    }
}
