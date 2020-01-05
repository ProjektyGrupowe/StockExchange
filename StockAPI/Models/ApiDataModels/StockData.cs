using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockAPI.Models.ApiDataModels
{
    using System.Globalization;
    using Newtonsoft.Json;

    public partial class StockData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } 
        [Key]
        [JsonProperty("quote")]
        public Quote Quote { get; set; }
        [Key]
        [JsonProperty("chart")]
        public List<Chart> Chart { get; set; }
    }
}
