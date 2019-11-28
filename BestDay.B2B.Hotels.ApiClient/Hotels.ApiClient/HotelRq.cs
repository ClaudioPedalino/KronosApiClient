using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotels.ApiClient
{
    [MessagePackObject]
    public class HotelRq
    {
        [Key(0)]
        public int HotelId { get; set; }
        [Key(1)]
        public int HotelInterface { get; set; }
        [Key(2)]
        public int HotelContract { get; set; }
        [Key(3)]
        public string HotelMarket { get; set; }
        [Key(4)]
        public string HotelCountry { get; set; }
        [Key(5)]
        public string HotelState { get; set; }
        [Key(6)]
        public string HotelCity { get; set; }
        [Key(7)]
        public int HotelDestination { get; set; }
        [Key(8)]
        public string HotelOperator { get; set; }
        [Key(9)]
        public string HotelChain { get; set; }
        [Key(10)]
        public int HotelCancelPolicy { get; set; }
        [Key(11)]
        public Configuration Comission { get; set; }
        [Key(12)]
        public Configuration Retention { get; set; }
        [Key(13)]
        public IEnumerable<Rate> Rates { get; set; }
    }
}
