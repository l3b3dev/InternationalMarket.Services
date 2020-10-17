using System;
using System.Threading.Tasks;
using AutoMapper;
using InternationalMarket.BusinessComponent.Liability.Interfaces;
using InternationalMarket.BusinessEntity.Liability;
using InternationalMarket.ServiceGateways.Interfaces;

namespace InternationalMarket.BusinessComponent.Liability
{
    /// <summary>
    ///  TaxCalculator
    /// </summary>
    /// <seealso cref="InternationalMarket.BusinessComponent.Liability.Interfaces.ITaxCalculator" />
    public class TaxCalculator : ITaxCalculator
    {
        private readonly ISalesTaxClient _salesTaxClient;
        private readonly IMapper _mapper;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCalculator"/> class.
        /// </summary>
        /// <param name="salesTaxClient">The sales tax client.</param>
        /// <param name="mapper">The mapper.</param>
        public TaxCalculator(ISalesTaxClient salesTaxClient, IMapper mapper)
        {
            _salesTaxClient = salesTaxClient;
            _mapper = mapper;
        }

        #endregion

        /// <summary>
        /// Show tax rates for a location
        /// </summary>
        /// <param name="zip"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<TaxRate> RatesForLocation(string zip, dynamic parameters)
        {
            return await _salesTaxClient.RatesForLocation(zip, parameters);
        }

        /// <summary>
        /// Taxes for order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        public async Task<Tax> TaxForOrder(Order order)
        {
            return await _salesTaxClient.TaxForOrder(order);
        }
    }
}
