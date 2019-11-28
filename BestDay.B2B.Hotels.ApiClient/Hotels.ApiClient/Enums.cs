using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotels.ApiClient
{
    public struct AgencyType
    {
        public const int None = 0;
        public const int Retailer = 4;
        public const int RetailerTop = 5;
        public const int WholesalerB2B = 6;
        public const int WholesalerB2C = 7;
        public static int Retention;
        public static int CommissionableWithRetention;
        public static int Commissionable;
    }
}
