using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace module3_ExploringExamples.Models
{
    public class Sell
    {
        public int Id { get; set; }

        //Attribute Json to serialize an especific object w/ different name
        [JsonProperty("Product_Name")]
        public string Product { get; set; }

        public decimal Price { get; set; }

        public DateTime SellDate { get; set; }

        public decimal? Discount { get; set; }

    }
}