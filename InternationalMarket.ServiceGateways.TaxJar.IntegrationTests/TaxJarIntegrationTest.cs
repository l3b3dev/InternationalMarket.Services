using System.Collections.Generic;
using AutoMapper;
using InternationalMarket.BusinessEntity.Liability;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InternationalMarket.ServiceGateways.TaxJar.IntegrationTests
{
    [TestClass]
    public class TaxJarIntegrationTest
    {
        #region Private Members

        protected static IMapper Mapper;

        #endregion

        /// <summary>
        /// Taxes the jar initialize.
        /// </summary>
        /// <param name="testContext">The test context.</param>
        [ClassInitialize()]
        public static void TaxJarInitialize(TestContext testContext)
        {
            SetupMapper();
        }

        /// <summary>
        /// Setups the container.
        /// </summary>
        private static void SetupMapper()
        {
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            Mapper = mapperConfig.CreateMapper();
        }

        [TestMethod]
        public void SalesTaxClient_RatesForLocation_OnlyZip_Success()
        {
            //Arrange
            var component = new SalesTaxClient("https://api.taxjar.com", "5da2f821eee4035db4771edab942a4cc", Mapper);

            //Act
            var result = component.RatesForLocation("32259").Result;

            //Assert
            Assert.AreEqual(0.065M,result.CombinedRate);
        }

        [TestMethod]
        public void SalesTaxClient_RatesForLocation_ZipWithDetails_Success()
        {
            //Arrange
            var component = new SalesTaxClient("https://api.taxjar.com", "5da2f821eee4035db4771edab942a4cc", Mapper);

            //Act
            var result = component.RatesForLocation("05495-2086", new 
            {
                street = "312 Hurricane Lane",
                city = "Williston",
                state = "VT",
                country = "US"
            }).Result;

            //Assert
            Assert.AreEqual("WILLISTON",result.City);
        }

        [TestMethod]
        public void SalesTaxClient_RatesForLocation_ZipWithDetailsForCali_Success()
        {
            //Arrange
            var component = new SalesTaxClient("https://api.taxjar.com", "5da2f821eee4035db4771edab942a4cc", Mapper);

            //Act
            var result = component.RatesForLocation("90404", new 
            {
                city = "Santa Monica",
                state = "CA",
                country = "US"
            }).Result;

            //Assert
            Assert.AreEqual("SANTA MONICA",result.City);
        }

        [TestMethod]
        public void SalesTaxClient_TaxForOrder_CaliOrder_Success()
        {
            //Arrange
            var component = new SalesTaxClient("https://api.taxjar.com", "5da2f821eee4035db4771edab942a4cc", Mapper);
            var order = new Order
            {
                FromCountry = "US",
                FromZip = "92093",
                FromState = "CA",
                FromCity = "La Jolla",
                FromStreet = "9500 Gilman Drive",
                ToCountry = "US",
                ToZip = "90002",
                ToState = "CA",
                ToCity = "Los Angeles",
                ToStreet = "1335 E 103rd St",
                Amount = 15,
                Shipping = 1.5M,
                NexusAddresses = new List<OrderNexusAddress>
                {
                    new OrderNexusAddress
                    {
                        Id = "Main Location",
                        Country = "US",
                        Zip = "92093",
                        State = "CA",
                        City = "La Jolla",
                        Street = "9500 Gilman Drive",
                    }
                },
                LineItems = new List<OrderLineItem>
                {
                    new OrderLineItem
                    {
                        Id = "1",
                        Quantity = 1,
                        ProductTaxCode = "20010",
                        UnitPrice = 15,
                        Discount = 0
                    }
                }
            };

            //Act
            var result = component.TaxForOrder(order).Result;

            //Assert
            Assert.AreEqual(16.5M,result.OrderTotalAmount);
            Assert.AreEqual(1.43M,result.AmountToCollect);
            Assert.IsNotNull(result.Jurisdictions);
            Assert.IsNotNull(result.Breakdown);
        }
    }
}
