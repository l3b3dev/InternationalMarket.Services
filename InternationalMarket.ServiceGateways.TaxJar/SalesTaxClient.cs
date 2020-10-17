using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using InternationalMarket.BusinessEntity.Liability;
using InternationalMarket.ServiceGateways.Interfaces;
using InternationalMarket.ServiceGateways.TaxJar.Entities;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace InternationalMarket.ServiceGateways.TaxJar
{
    /// <summary>
    /// Implementing Tax Jar as one of our calculators. 
    /// </summary>
    /// <seealso cref="InternationalMarket.ServiceGateways.Interfaces.ISalesTaxClient" />
    public class SalesTaxClient : ISalesTaxClient
    {
        private readonly string _baseUrl;
        private readonly string _apiVersion = "v2";
        private readonly string _apiToken;
        private readonly IMapper _mapper;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesTaxClient"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="apiToken"></param>
        /// <param name="mapper"></param>
        public SalesTaxClient(string baseUrl, string apiToken, IMapper mapper)
        {
            _apiToken = apiToken;
            _mapper = mapper;
            _baseUrl = baseUrl;
        }

        #endregion

        /// <summary>
        /// Show tax rates for a location
        /// </summary>
        /// <param name="zip"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">zip</exception>
        public async Task<TaxRate> RatesForLocation(string zip, dynamic parameters=null)
        {
            if (zip == null) throw new ArgumentNullException(nameof(zip));

            var requestUrl = $"{_baseUrl}/{_apiVersion}/rates/{zip}";
            var query = new Dictionary<string,string>();
            if (parameters != null)
            {
                //if optionals are present add them
                query = ((IEnumerable<PropertyInfo>) parameters.GetType()
                        .GetProperties(BindingFlags.Instance | BindingFlags.Public))
                    .ToDictionary(t => t.Name, t => (string)t.GetValue(parameters));
            }

            using var httpClient = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri =  new Uri(QueryHelpers.AddQueryString(requestUrl, query))
            };
           

            request.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", _apiToken);
            var response = await httpClient.SendAsync(request).ConfigureAwait(false);
            //// Throw if there is an error
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var rates = JsonConvert.DeserializeObject<RateResponse>(content);

            return _mapper.Map<TaxRate>(rates.Rate);
        }

        /// <summary>
        /// Taxes for order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">order</exception>
        public async Task<Tax> TaxForOrder(Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));

            var requestUrl = $"{_baseUrl}/{_apiVersion}/taxes";

            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", _apiToken);

            var payload = JsonConvert.SerializeObject(_mapper.Map<TaxOrder>(order));
            var response = await httpClient
                .PostAsync(requestUrl, new StringContent(payload, Encoding.UTF8, "application/json"))
                .ConfigureAwait(false);
            //// Throw if there is an error
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var taxResponse = JsonConvert.DeserializeObject<TaxResponse>(content);

            return _mapper.Map<Tax>(taxResponse.Tax);
        }
    }
}
