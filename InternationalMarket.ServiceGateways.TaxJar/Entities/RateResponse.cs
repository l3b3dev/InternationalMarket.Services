using InternationalMarket.BusinessEntity.Liability;
using Newtonsoft.Json;

namespace InternationalMarket.ServiceGateways.TaxJar.Entities
{
    /// <summary>
    /// Show tax rates for a location
    /// </summary>
    public class RateResponse
    {
        [JsonProperty("rate")]
        public Rate Rate { get; set; }
    }
}
