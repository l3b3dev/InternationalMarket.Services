using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace InternationalMarket.ServiceGateways.TaxJar.Entities
{
    /// <summary>
    /// Taxes for order:  per https://github.com/taxjar/taxjar.net/blob/9302158cd84c211b8d4263ee5879db6540291ed0/src/Taxjar/Entities
    /// </summary>
    public class TaxResponse
    {
        [JsonProperty("tax")]
        public TaxResponseAttributes Tax { get; set; }
    }

    /// <summary>
    ///  TaxResponseAttributes
    /// </summary>
    public class TaxResponseAttributes
    {
        [JsonProperty("order_total_amount")]
        public decimal OrderTotalAmount { get; set; }

        [JsonProperty("shipping")]
        public decimal Shipping { get; set; }

        [JsonProperty("taxable_amount")]
        public decimal TaxableAmount { get; set; }

        [JsonProperty("amount_to_collect")]
        public decimal AmountToCollect { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        [JsonProperty("has_nexus")]
        public bool HasNexus { get; set; }

        [JsonProperty("freight_taxable")]
        public bool FreightTaxable { get; set; }

        [JsonProperty("tax_source")]
        public string TaxSource { get; set; }

        [JsonProperty("exemption_type")]
        public string ExemptionType { get; set; }

        [JsonProperty("jurisdictions")]
        public TaxJurisdictions Jurisdictions { get; set; }

        [JsonProperty("breakdown")]
        public TaxBreakdown Breakdown { get; set; }
    }

    /// <summary>
    /// Tax Jurisdictions per 
    /// </summary>
    public class TaxJurisdictions
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }

    /// <summary>
    /// Breakdown
    /// </summary>
    public class Breakdown
    {
        [JsonProperty("taxable_amount")]
        public decimal TaxableAmount { get; set; }

        [JsonProperty("tax_collectable")]
        public decimal TaxCollectable { get; set; }

        [JsonProperty("combined_tax_rate")]
        public decimal CombinedTaxRate { get; set; }

        [JsonProperty("state_taxable_amount")]
        public decimal StateTaxableAmount { get; set; }

        [JsonProperty("county_taxable_amount")]
        public decimal CountyTaxableAmount { get; set; }

        [JsonProperty("county_tax_rate")]
        public decimal CountyTaxRate { get; set; }

        [JsonProperty("city_taxable_amount")]
        public decimal CityTaxableAmount { get; set; }

        [JsonProperty("city_tax_rate")]
        public decimal CityTaxRate { get; set; }

        // International
        [JsonProperty("country_taxable_amount")]
        public decimal CountryTaxableAmount { get; set; }

        [JsonProperty("country_tax_rate")]
        public decimal CountryTaxRate { get; set; }

        [JsonProperty("country_tax_collectable")]
        public decimal CountryTaxCollectable { get; set; }

        // Canada
        [JsonProperty("gst_taxable_amount")]
        public decimal GSTTaxableAmount { get; set; }

        [JsonProperty("gst_tax_rate")]
        public decimal GSTTaxRate { get; set; }

        [JsonProperty("gst")]
        public decimal GST { get; set; }

        [JsonProperty("pst_taxable_amount")]
        public decimal PSTTaxableAmount { get; set; }

        [JsonProperty("pst_tax_rate")]
        public decimal PSTTaxRate { get; set; }

        [JsonProperty("pst")]
        public decimal PST { get; set; }

        [JsonProperty("qst_taxable_amount")]
        public decimal QSTTaxableAmount { get; set; }

        [JsonProperty("qst_tax_rate")]
        public decimal QSTTaxRate { get; set; }

        [JsonProperty("qst")]
        public decimal QST { get; set; }
    }

    /// <summary>
    ///  TaxBreakdown
    /// </summary>
    /// <seealso cref="InternationalMarket.ServiceGateways.TaxJar.Entities.Breakdown" />
    public class TaxBreakdown : Breakdown
    {
        [JsonProperty("state_tax_rate")]
        public decimal StateTaxRate { get; set; }

        [JsonProperty("state_tax_collectable")]
        public decimal StateTaxCollectable { get; set; }

        [JsonProperty("county_tax_collectable")]
        public decimal CountyTaxCollectable { get; set; }

        [JsonProperty("city_tax_collectable")]
        public decimal CityTaxCollectable { get; set; }

        [JsonProperty("special_district_taxable_amount")]
        public decimal SpecialDistrictTaxableAmount { get; set; }

        [JsonProperty("special_tax_rate")]
        public decimal SpecialDistrictTaxRate { get; set; }

        [JsonProperty("special_district_tax_collectable")]
        public decimal SpecialDistrictTaxCollectable { get; set; }

        [JsonProperty("shipping")]
        public TaxBreakdownShipping Shipping { get; set; }

        [JsonProperty("line_items")]
        public List<TaxBreakdownLineItem> LineItems { get; set; }
    }

    /// <summary>
    ///  TaxBreakdownShipping
    /// </summary>
    /// <seealso cref="InternationalMarket.ServiceGateways.TaxJar.Entities.Breakdown" />
    public class TaxBreakdownShipping : Breakdown
    {
        [JsonProperty("state_sales_tax_rate")]
        public decimal StateSalesTaxRate { get; set; }

        [JsonProperty("state_amount")]
        public decimal StateAmount { get; set; }

        [JsonProperty("county_amount")]
        public decimal CountyAmount { get; set; }

        [JsonProperty("city_amount")]
        public decimal CityAmount { get; set; }

        [JsonProperty("special_taxable_amount")]
        public decimal SpecialDistrictTaxableAmount { get; set; }

        [JsonProperty("special_tax_rate")]
        public decimal SpecialDistrictTaxRate { get; set; }

        [JsonProperty("special_district_amount")]
        public decimal SpecialDistrictAmount { get; set; }
    }

    /// <summary>
    ///  TaxBreakdownLineItem
    /// </summary>
    /// <seealso cref="InternationalMarket.ServiceGateways.TaxJar.Entities.Breakdown" />
    public class TaxBreakdownLineItem : Breakdown
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state_sales_tax_rate")]
        public decimal StateSalesTaxRate { get; set; }

        [JsonProperty("state_amount")]
        public decimal StateAmount { get; set; }

        [JsonProperty("county_amount")]
        public decimal CountyAmount { get; set; }

        [JsonProperty("city_amount")]
        public decimal CityAmount { get; set; }

        [JsonProperty("special_district_taxable_amount")]
        public decimal SpecialDistrictTaxableAmount { get; set; }

        [JsonProperty("special_tax_rate")]
        public decimal SpecialTaxRate { get; set; }

        [JsonProperty("special_district_amount")]
        public decimal SpecialDistrictAmount { get; set; }
    }

}
