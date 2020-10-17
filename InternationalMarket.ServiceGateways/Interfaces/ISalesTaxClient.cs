using System.Threading.Tasks;
using InternationalMarket.BusinessEntity.Liability;

namespace InternationalMarket.ServiceGateways.Interfaces
{
    /// <summary>
    /// Allows for abstracting all different SalesTax api clients
    /// </summary>
    public interface ISalesTaxClient
    {
        /// <summary>
        /// Show tax rates for a location
        /// </summary>
        /// <returns></returns>
        Task<TaxRate> RatesForLocation(string zip, dynamic parameters);
        /// <summary>
        /// Taxes for order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        Task<Tax> TaxForOrder(Order order);
    }
}