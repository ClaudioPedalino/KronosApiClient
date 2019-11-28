using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotels.ApiClient
{
    [MessagePackObject]
    public class Configuration
    {
        [Key(0)]
        public int Id { get; set; }
        [Key(1)]
        public decimal Percent { get; set; }
        [Key(2)]
        public bool IsDifferential { get; set; }
        [Key(3)]
        public string Key { get; set; }

    }
}
