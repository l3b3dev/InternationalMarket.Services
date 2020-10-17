using System;
using System.Collections.Generic;
using System.Text;

namespace InternationalMarket.BusinessEntity.Liability
{
    /// <summary>
    ///  Tax
    /// </summary>
    public class Tax
    {
        /// <summary>
        /// Gets or sets the order total amount.
        /// </summary>
        /// <value>
        /// The order total amount.
        /// </value>
        public decimal OrderTotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the shipping.
        /// </summary>
        /// <value>
        /// The shipping.
        /// </value>
        public decimal Shipping { get; set; }

        /// <summary>
        /// Gets or sets the taxable amount.
        /// </summary>
        /// <value>
        /// The taxable amount.
        /// </value>
        public decimal TaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the amount to collect.
        /// </summary>
        /// <value>
        /// The amount to collect.
        /// </value>
        public decimal AmountToCollect { get; set; }

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>
        /// The rate.
        /// </value>
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has nexus.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has nexus; otherwise, <c>false</c>.
        /// </value>
        public bool HasNexus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [freight taxable].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [freight taxable]; otherwise, <c>false</c>.
        /// </value>
        public bool FreightTaxable { get; set; }

        /// <summary>
        /// Gets or sets the tax source.
        /// </summary>
        /// <value>
        /// The tax source.
        /// </value>
        public string TaxSource { get; set; }

        /// <summary>
        /// Gets or sets the type of the exemption.
        /// </summary>
        /// <value>
        /// The type of the exemption.
        /// </value>
        public string ExemptionType { get; set; }

        /// <summary>
        /// Gets or sets the jurisdictions.
        /// </summary>
        /// <value>
        /// The jurisdictions.
        /// </value>
        public LiabilityJurisdictions Jurisdictions { get; set; }

        /// <summary>
        /// Gets or sets the breakdown.
        /// </summary>
        /// <value>
        /// The breakdown.
        /// </value>
        public Breakdown Breakdown { get; set; }
    }

    /// <summary>
    /// LiabilityJurisdictions
    /// </summary>
    public class LiabilityJurisdictions
    {
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }
    }

    /// <summary>
    /// LiabilityBreakdown
    /// </summary>
    public class LiabilityBreakdown
    {
        /// <summary>
        /// Gets or sets the taxable amount.
        /// </summary>
        /// <value>
        /// The taxable amount.
        /// </value>
        public decimal TaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the tax collectable.
        /// </summary>
        /// <value>
        /// The tax collectable.
        /// </value>
        public decimal TaxCollectable { get; set; }

        /// <summary>
        /// Gets or sets the combined tax rate.
        /// </summary>
        /// <value>
        /// The combined tax rate.
        /// </value>
        public decimal CombinedTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the state taxable amount.
        /// </summary>
        /// <value>
        /// The state taxable amount.
        /// </value>
        public decimal StateTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the county taxable amount.
        /// </summary>
        /// <value>
        /// The county taxable amount.
        /// </value>
        public decimal CountyTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the county tax rate.
        /// </summary>
        /// <value>
        /// The county tax rate.
        /// </value>
        public decimal CountyTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the city taxable amount.
        /// </summary>
        /// <value>
        /// The city taxable amount.
        /// </value>
        public decimal CityTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the city tax rate.
        /// </summary>
        /// <value>
        /// The city tax rate.
        /// </value>
        public decimal CityTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the country taxable amount.
        /// </summary>
        /// <value>
        /// The country taxable amount.
        /// </value>
        public decimal CountryTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the country tax rate.
        /// </summary>
        /// <value>
        /// The country tax rate.
        /// </value>
        public decimal CountryTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the country tax collectable.
        /// </summary>
        /// <value>
        /// The country tax collectable.
        /// </value>
        public decimal CountryTaxCollectable { get; set; }

        /// <summary>
        /// Gets or sets the GST taxable amount.
        /// </summary>
        /// <value>
        /// The GST taxable amount.
        /// </value>
        public decimal GSTTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the GST tax rate.
        /// </summary>
        /// <value>
        /// The GST tax rate.
        /// </value>
        public decimal GSTTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the GST.
        /// </summary>
        /// <value>
        /// The GST.
        /// </value>
        public decimal GST { get; set; }

        /// <summary>
        /// Gets or sets the PST taxable amount.
        /// </summary>
        /// <value>
        /// The PST taxable amount.
        /// </value>
        public decimal PSTTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the PST tax rate.
        /// </summary>
        /// <value>
        /// The PST tax rate.
        /// </value>
        public decimal PSTTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the PST.
        /// </summary>
        /// <value>
        /// The PST.
        /// </value>
        public decimal PST { get; set; }

        /// <summary>
        /// Gets or sets the QST taxable amount.
        /// </summary>
        /// <value>
        /// The QST taxable amount.
        /// </value>
        public decimal QSTTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the QST tax rate.
        /// </summary>
        /// <value>
        /// The QST tax rate.
        /// </value>
        public decimal QSTTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the QST.
        /// </summary>
        /// <value>
        /// The QST.
        /// </value>
        public decimal QST { get; set; }
    }

    /// <summary>
    /// Breakdown
    /// </summary>
    /// <seealso cref="InternationalMarket.BusinessEntity.Liability.LiabilityBreakdown" />
    public class Breakdown : LiabilityBreakdown
    {
        /// <summary>
        /// Gets or sets the state tax rate.
        /// </summary>
        /// <value>
        /// The state tax rate.
        /// </value>
        public decimal StateTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the state tax collectable.
        /// </summary>
        /// <value>
        /// The state tax collectable.
        /// </value>
        public decimal StateTaxCollectable { get; set; }

        /// <summary>
        /// Gets or sets the county tax collectable.
        /// </summary>
        /// <value>
        /// The county tax collectable.
        /// </value>
        public decimal CountyTaxCollectable { get; set; }

        /// <summary>
        /// Gets or sets the city tax collectable.
        /// </summary>
        /// <value>
        /// The city tax collectable.
        /// </value>
        public decimal CityTaxCollectable { get; set; }

        /// <summary>
        /// Gets or sets the special district taxable amount.
        /// </summary>
        /// <value>
        /// The special district taxable amount.
        /// </value>
        public decimal SpecialDistrictTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the special district tax rate.
        /// </summary>
        /// <value>
        /// The special district tax rate.
        /// </value>
        public decimal SpecialDistrictTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the special district tax collectable.
        /// </summary>
        /// <value>
        /// The special district tax collectable.
        /// </value>
        public decimal SpecialDistrictTaxCollectable { get; set; }

        /// <summary>
        /// Gets or sets the shipping.
        /// </summary>
        /// <value>
        /// The shipping.
        /// </value>
        public BreakdownShipping Shipping { get; set; }

        /// <summary>
        /// Gets or sets the line items.
        /// </summary>
        /// <value>
        /// The line items.
        /// </value>
        public List<BreakdownLineItem> LineItems { get; set; }
    }

    /// <summary>
    /// BreakdownShipping
    /// </summary>
    /// <seealso cref="InternationalMarket.BusinessEntity.Liability.LiabilityBreakdown" />
    public class BreakdownShipping : LiabilityBreakdown
    {
        /// <summary>
        /// Gets or sets the state sales tax rate.
        /// </summary>
        /// <value>
        /// The state sales tax rate.
        /// </value>
        public decimal StateSalesTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the state amount.
        /// </summary>
        /// <value>
        /// The state amount.
        /// </value>
        public decimal StateAmount { get; set; }

        /// <summary>
        /// Gets or sets the county amount.
        /// </summary>
        /// <value>
        /// The county amount.
        /// </value>
        public decimal CountyAmount { get; set; }

        /// <summary>
        /// Gets or sets the city amount.
        /// </summary>
        /// <value>
        /// The city amount.
        /// </value>
        public decimal CityAmount { get; set; }

        /// <summary>
        /// Gets or sets the special district taxable amount.
        /// </summary>
        /// <value>
        /// The special district taxable amount.
        /// </value>
        public decimal SpecialDistrictTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the special district tax rate.
        /// </summary>
        /// <value>
        /// The special district tax rate.
        /// </value>
        public decimal SpecialDistrictTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the special district amount.
        /// </summary>
        /// <value>
        /// The special district amount.
        /// </value>
        public decimal SpecialDistrictAmount { get; set; }
    }

    /// <summary>
    /// BreakdownLineItem
    /// </summary>
    /// <seealso cref="InternationalMarket.BusinessEntity.Liability.LiabilityBreakdown" />
    public class BreakdownLineItem : LiabilityBreakdown
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the state sales tax rate.
        /// </summary>
        /// <value>
        /// The state sales tax rate.
        /// </value>
        public decimal StateSalesTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the state amount.
        /// </summary>
        /// <value>
        /// The state amount.
        /// </value>
        public decimal StateAmount { get; set; }

        /// <summary>
        /// Gets or sets the county amount.
        /// </summary>
        /// <value>
        /// The county amount.
        /// </value>
        public decimal CountyAmount { get; set; }

        /// <summary>
        /// Gets or sets the city amount.
        /// </summary>
        /// <value>
        /// The city amount.
        /// </value>
        public decimal CityAmount { get; set; }

        /// <summary>
        /// Gets or sets the special district taxable amount.
        /// </summary>
        /// <value>
        /// The special district taxable amount.
        /// </value>
        public decimal SpecialDistrictTaxableAmount { get; set; }

        /// <summary>
        /// Gets or sets the special tax rate.
        /// </summary>
        /// <value>
        /// The special tax rate.
        /// </value>
        public decimal SpecialTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the special district amount.
        /// </summary>
        /// <value>
        /// The special district amount.
        /// </value>
        public decimal SpecialDistrictAmount { get; set; }
    }
}
