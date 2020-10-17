using AutoMapper;
using InternationalMarket.BusinessComponent.Liability.Interfaces;
using InternationalMarket.BusinessEntity.Liability;
using InternationalMarket.ServiceGateways.TaxJar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace InternationalMarket.Services.UnitTests
{
    [TestClass]
    public class TaxServiceUnitTest
    {
        #region Private Members

        protected static IMapper Mapper;
        protected static ITaxCalculator TaxCalculator;

        #endregion

        /// <summary>
        /// Taxes the jar initialize.
        /// </summary>
        /// <param name="testContext">The test context.</param>
        [ClassInitialize()]
        public static void TaxJarInitialize(TestContext testContext)
        {
            SetupMapper();
            SetupCalculator();
        }

        private static void SetupCalculator()
        {
            var taxCalculatorMoq = new Mock<ITaxCalculator>();
            //illustrating the principal since SaxService has no business logic but just pass thru
            taxCalculatorMoq.Setup(c => c.RatesForLocation(It.IsAny<string>(), It.IsAny<object>()))
                .ReturnsAsync(new TaxRate
                {
                    CombinedRate = 0.065M
                });

            TaxCalculator = taxCalculatorMoq.Object;
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
        public void TaxService_RatesForLocation_Called_Success()
        {
            //Arrange
            var component = new TaxService(Mapper, TaxCalculator);

            //Act
            var result = component.RatesForLocation("05495-2086", new 
            {
                street = "312 Hurricane Lane",
                city = "Williston",
                state = "VT",
                country = "US"
            }).Result;

            //Assert
            Assert.AreEqual(0.065M,result.CombinedRate);
        }
    }
}
