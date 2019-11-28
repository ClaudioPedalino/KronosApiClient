using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotels.ApiClient
{
    [MessagePackObject]
    public class RqHotelComission
    {
        [Key(0)]
        public AffiliateRq AffiliateRq { get; set; }

        [Key(1)]
        public string ClientCountry { get; set; }

        [Key(2)]
        public int NightStay { get; set; }

        [Key(3)]
        public IEnumerable<HotelRq> Hotels { get; set; }
    }
}
