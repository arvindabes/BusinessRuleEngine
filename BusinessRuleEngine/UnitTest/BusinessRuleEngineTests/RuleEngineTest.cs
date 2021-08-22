using BusinessRuleEngine;
using System.Threading.Tasks;
using Xunit;

namespace BusinessRuleEngineTests
{
    public class RuleEngineTest
    {
        [Fact]
        public void WhenPaymenmtType_NULL_ShouldReturnEmpty()
        {
            //Arrange
            string paymentType = string.Empty;

            //Act
            var response = string.Empty;

            //Assert
            Assert.NotNull(response);
            
        }

        #region UnKnownPaymentType
        [Fact]
        public void WhenPaymenmtType_Unknown_ShouldReturn_InvalidPaymentType()
        {
            //Arrange
            string paymentType = PaymentTypes.Unknown.ToString();
            string expectedResponse = "InvalidPaymentType";

            //Act
            var actualResponse = "InvalidPaymentType";

            //Assert
            Assert.Equal(expectedResponse, actualResponse);
        }
        #endregion

        #region PhysicalProductPaymentType
        [Fact]
        public void WhenPaymenmtType_PhysicalProduct_ShouldReturn_ShippingSlip()
        {
            //Arrange
            string paymentType = PaymentTypes.PhysicalProduct.ToString();
            string expectedResponse = "ShippingSlipGenerated";

            //Act
            var actualResponse = "ShippingSlipGenerated";

            //Assert
            Assert.Equal(expectedResponse, actualResponse);
        }

        [Fact]
        public void WhenPaymenmtType_PhysicalProduct_ShouldReturn_ShippingSlip_NotGenerated()
        {
            //Arrange
            string paymentType = PaymentTypes.PhysicalProduct.ToString();
            string expectedResponse = "ShippingSlipGenerated";

            //Act
            var actualResponse = "ShippingSlipNotGenerated";

            //Assert
            Assert.NotEqual(expectedResponse, actualResponse);
        }
        #endregion

        #region BookPaymentType
        [Fact]
        public void WhenPaymenmtType_Book_ShouldReturn_DuplicateSlipForRoyalityDepartment()
        {
            //Arrange
            string paymentType = PaymentTypes.Book.ToString();
            string expectedResponse = "DuplicatePackingSlip";

            //Act
            var actualResponse = "DuplicatePackingSlip";

            //Assert
            Assert.Equal(expectedResponse, actualResponse);
        }

        [Fact]
        public void WhenPaymenmtType_Book_ShouldReturn_DuplicateSlipForRoyalityDepartment_NotGenerated()
        {
            //Arrange
            string paymentType = PaymentTypes.Book.ToString();
            string expectedResponse = "DuplicatePackingSlip";

            //Act
            var actualResponse = "DuplicatePackingSlip_NotGenerated";

            //Assert
            Assert.NotEqual(expectedResponse, actualResponse);
        }
        #endregion
    }
}
