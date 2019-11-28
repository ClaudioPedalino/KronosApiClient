using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotels.ApiClient
{
    [MessagePackObject]
    public class Rate
    {
        [Key(0)]
        public string Key { get; set; }
        [Key(1)]
        public decimal AgencyPublic { get; set; }
        [Key(2)]
        public decimal Normal { get; set; }
        [Key(3)]
        public decimal Total { get; set; }
        [Key(4)]
        public decimal ProviderNetRate { get; set; }
        [Key(5)]
        public decimal NetRate { get; set; }
        [Key(6)]
        public DateTime Date { get; set; }
    }
}
