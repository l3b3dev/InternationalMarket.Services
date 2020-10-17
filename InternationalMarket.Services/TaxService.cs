using System;
using System.Threading.Tasks;
using AutoMapper;
using InternationalMarket.BusinessComponent.Liability.Interfaces;
using InternationalMarket.BusinessEntity.Liability;
using InternationalMarket.Services.Interfaces;

namespace InternationalMarket.Services
{
    /// <summary>
    /// TaxService
    /// </summary>
    /// <seealso cref="InternationalMarket.Services.Interfaces.ITaxService" />
    public class TaxService : ITaxService
    {
        private readonly ITaxCalculator _salesCalculator;
        private readonly IMapper _mapper;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxService"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="salesCalculator"></param>
        public TaxService(IMapper mapper, ITaxCalculator salesCalculator)
        {
            _mapper = mapper;
            _salesCalculator = salesCalculator;
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
            return await _salesCalculator.RatesForLocation(zip, parameters);
        }

        /// <summary>
        /// Taxes for order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        public async Task<Tax> TaxForOrder(Order order)
        {
            return await _salesCalculator.TaxForOrder(order);
        }
    }
}
