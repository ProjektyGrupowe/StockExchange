using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Models.PostDataModels
{
    public class PostData
    {
        [JsonProperty("Symbols")]
        public string Symbols { get; set; }
    }
}
