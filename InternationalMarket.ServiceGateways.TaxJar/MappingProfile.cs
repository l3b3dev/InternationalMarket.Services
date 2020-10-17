using AutoMapper;
using InternationalMarket.BusinessEntity.Liability;
using InternationalMarket.ServiceGateways.TaxJar.Entities;
using LiaBreakdown = InternationalMarket.BusinessEntity.Liability.Breakdown;

namespace InternationalMarket.ServiceGateways.TaxJar
{
    /// <summary>
    /// MappingProfile
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class MappingProfile : Profile {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingProfile"/> class.
        /// </summary>
        public MappingProfile() {
            CreateMap<Rate, TaxRate>();
            CreateMap<Order, TaxOrder>();
            CreateMap<OrderNexusAddress, NexusAddress>();
            CreateMap<OrderLineItem, LineItem>();
            CreateMap<TaxResponseAttributes, Tax>();
            CreateMap<TaxJurisdictions, LiabilityJurisdictions>();
            CreateMap<TaxBreakdown, LiaBreakdown>();
            CreateMap<TaxBreakdownShipping, BreakdownShipping>();
            CreateMap<TaxBreakdownLineItem, BreakdownLineItem>();
        }
    }
}