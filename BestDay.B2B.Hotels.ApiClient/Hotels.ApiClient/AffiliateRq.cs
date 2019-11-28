using System;
using MessagePack;

namespace Hotels.ApiClient
{
    [MessagePackObject]
    public class AffiliateRq
    {
        [Key(0)]
        public int ConfigId { get; set; }
        [Key(1)]
        public string AffiliateId { get; set; }
        [Key(2)]
        public string AffiliateGrouper { get; set; }
        [Key(3)]
        public string AffiliateCompany { get; set; }
        [Key(4)]
        public string AffiliateCity { get; set; }
        [Key(5)]
        public string AffiliateState { get; set; }
        [Key(6)]
        public string AffiliateCountry { get; set; }
        [Key(7)]
        public string AffiliateUser { get; set; }
        [Key(8)]
        public int AffiliateContinent { get; set; }
        [Key(9)]
        public int AffiliateCategory { get; set; }
        [Key(10)]
        public int AffiliateCommercialBusiness { get; set; }
        [Key(11)]
        public int AffiliateProfitCenter { get; set; }

        [Key(12)]
        public int Scheme { get; set; }
        [Key(13)]
        public bool TaxApply { get; set; }
        [Key(14)]
        public bool DisplayCalculator { get; set; }
        [Key(15)]
        public bool IgnoreDifferentialComissions { get; set; }
        [Key(16)]
        public bool IgnoreDifferentialRetentions { get; set; }
        [Key(17)]
        public bool IgnorePaymentMethodDiscounts { get; set; }

        [Key(18)]
        public bool IsAgencyCommissionable => false;

        [Key(19)]
        public bool ApplyLodgeHotel => true;

        [Key(20)]
        public bool IgnorePublicRateDiscounts { get; set; }
        [Key(21)]
        public bool ApplyRevenue { get; set; }
        [Key(22)]
        public decimal DefaultHotelRetention { get; set; }
        [Key(23)]
        public decimal DefaultActivityRetention { get; set; }
        [Key(24)]
        public decimal DefaultShuttleRetention { get; set; }
        [Key(25)]
        public decimal DefaultCarRetention { get; set; }
        [Key(26)]
        public decimal MinimumComission { get; set; }
        [Key(27)]
        public decimal TraditionalComission { get; set; }
        [Key(28)]
        public decimal MinimumRetention { get; set; }
        [Key(29)]
        public decimal PublicRateDiscount { get; set; }
        [Key(30)]
        public string PonderationKey { get; set; }
        [Key(31)]
        public int TotalFactors { get; set; }
        [Key(32)]
        public int Coincidences { get; set; }
        [Key(33)]
        public int Priority { get; set; }
    }
}
