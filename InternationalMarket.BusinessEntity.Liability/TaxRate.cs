using System;

namespace InternationalMarket.BusinessEntity.Liability
{
    /// <summary>
    /// TaxRate
    /// </summary>
    public class TaxRate
    {
        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public string Zip { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }
        /// <summary>
        /// Gets or sets the state rate.
        /// </summary>
        /// <value>
        /// The state rate.
        /// </value>
        public decimal StateRate { get; set; }
        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        public string County { get; set; }
        /// <summary>
        /// Gets or sets the county rate.
        /// </summary>
        /// <value>
        /// The county rate.
        /// </value>
        public decimal CountyRate { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the city rate.
        /// </summary>
        /// <value>
        /// The city rate.
        /// </value>
        public decimal CityRate { get; set; }
        /// <summary>
        /// Gets or sets the combined district rate.
        /// </summary>
        /// <value>
        /// The combined district rate.
        /// </value>
        public decimal CombinedDistrictRate { get; set; }
        /// <summary>
        /// Gets or sets the combined rate.
        /// </summary>
        /// <value>
        /// The combined rate.
        /// </value>
        public decimal CombinedRate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [freight taxable].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [freight taxable]; otherwise, <c>false</c>.
        /// </value>
        public bool FreightTaxable { get; set; }
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        // Australia / SST States
        public decimal CountryRate { get; set; }
        // European Union
        public decimal StandardRate { get; set; }
        /// <summary>
        /// Gets or sets the reduced rate.
        /// </summary>
        /// <value>
        /// The reduced rate.
        /// </value>
        public decimal ReducedRate { get; set; }
        /// <summary>
        /// Gets or sets the super reduced rate.
        /// </summary>
        /// <value>
        /// The super reduced rate.
        /// </value>
        public decimal SuperReducedRate { get; set; }
        /// <summary>
        /// Gets or sets the parking rate.
        /// </summary>
        /// <value>
        /// The parking rate.
        /// </value>
        public decimal ParkingRate { get; set; }
        /// <summary>
        /// Gets or sets the distance sale threshold.
        /// </summary>
        /// <value>
        /// The distance sale threshold.
        /// </value>
        public decimal DistanceSaleThreshold { get; set; }
    }
}
