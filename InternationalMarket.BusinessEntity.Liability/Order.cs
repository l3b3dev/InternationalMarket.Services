using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace InternationalMarket.BusinessEntity.Liability
{
    public class Order
    {
        /// <summary>
        /// Gets or sets from country.
        /// </summary>
        /// <value>
        /// From country.
        /// </value>
        public string FromCountry { get; set; }
        /// <summary>
        /// Gets or sets from zip.
        /// </summary>
        /// <value>
        /// From zip.
        /// </value>
        public string FromZip { get; set; }
        /// <summary>
        /// Gets or sets from state.
        /// </summary>
        /// <value>
        /// From state.
        /// </value>
        public string FromState { get; set; }
        /// <summary>
        /// Gets or sets from city.
        /// </summary>
        /// <value>
        /// From city.
        /// </value>
        public string FromCity { get; set; }
        /// <summary>
        /// Gets or sets from street.
        /// </summary>
        /// <value>
        /// From street.
        /// </value>
        public string FromStreet { get; set; }
        /// <summary>
        /// Converts to country.
        /// </summary>
        /// <value>
        /// To country.
        /// </value>
        public string ToCountry { get; set; }
        /// <summary>
        /// Converts to zip.
        /// </summary>
        /// <value>
        /// To zip.
        /// </value>
        public string ToZip { get; set; }
        /// <summary>
        /// Converts to state.
        /// </summary>
        /// <value>
        /// To state.
        /// </value>
        public string ToState { get; set; }
        /// <summary>
        /// Converts to city.
        /// </summary>
        /// <value>
        /// To city.
        /// </value>
        public string ToCity { get; set; }
        /// <summary>
        /// Converts to street.
        /// </summary>
        /// <value>
        /// To street.
        /// </value>
        public string ToStreet { get; set; }
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal Amount { get; set; }
        /// <summary>
        /// Gets or sets the shipping.
        /// </summary>
        /// <value>
        /// The shipping.
        /// </value>
        public decimal Shipping { get; set; }
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        public string CustomerId { get; set; }
        /// <summary>
        /// Gets or sets the type of the exemption.
        /// </summary>
        /// <value>
        /// The type of the exemption.
        /// </value>
        public string ExemptionType { get; set; }
        /// <summary>
        /// Gets or sets the nexus addresses.
        /// </summary>
        /// <value>
        /// The nexus addresses.
        /// </value>
        public List<OrderNexusAddress> NexusAddresses { get; set; }
        /// <summary>
        /// Gets or sets the line items.
        /// </summary>
        /// <value>
        /// The line items.
        /// </value>
        public List<OrderLineItem> LineItems { get; set; }
    }

    /// <summary>
    ///  NexusAddress
    /// </summary>
    public class OrderNexusAddress
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }
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
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        /// <value>
        /// The street.
        /// </value>
        public string Street { get; set; }
    }

    /// <summary>
    ///  LineItem
    /// </summary>
    public class OrderLineItem
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public string ProductIdentifier { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the product tax code.
        /// </summary>
        /// <value>
        /// The product tax code.
        /// </value>
        public string ProductTaxCode { get; set; }
        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>
        /// The unit price.
        /// </value>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// Gets or sets the discount.
        /// </summary>
        /// <value>
        /// The discount.
        /// </value>
        public decimal Discount { get; set; }
        /// <summary>
        /// Gets or sets the sales tax.
        /// </summary>
        /// <value>
        /// The sales tax.
        /// </value>
        public decimal SalesTax { get; set; }
    }
}
