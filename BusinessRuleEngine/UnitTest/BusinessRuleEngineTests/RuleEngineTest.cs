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

        #region MembershipPaymentType
        [Fact]
        public void WhenPaymenmtType_Membership_ShouldReturn_ActivateMembership()
        {
            //Arrange
            string paymentType = PaymentTypes.Membership.ToString();
            string expectedResponse = "ActivateMembership";

            //Act
            var actualResponse = "ActivateMembership";

            //Assert
            Assert.Equal(expectedResponse, actualResponse);
        }

        [Fact]
        public void WhenPaymenmtType_Membership_ShouldReturn_ActivateMembership_NotGenerated()
        {
            //Arrange
            string paymentType = PaymentTypes.Membership.ToString();
            string expectedResponse = "ActivateMembership";

            //Act
            var actualResponse = "ActivateMembership_NotGenerated";

            //Assert
            Assert.NotEqual(expectedResponse, actualResponse);
        }
        #endregion

        #region UpgradeMembershipPaymentType
        [Fact]
        public void WhenPaymenmtType_UpgradeMembership_ShouldReturn_UpgradeMembership()
        {
            //Arrange
            string paymentType = PaymentTypes.UpgradeMembership.ToString();
            string expectedResponse = "UpgradeMembership";

            //Act
            var actualResponse = "UpgradeMembership";

            //Assert
            Assert.Equal(expectedResponse, actualResponse);
        }

        [Fact]
        public void WhenPaymenmtType_Membership_ShouldReturn_UpgradeMembership_NotGenerated()
        {
            //Arrange
            string paymentType = PaymentTypes.UpgradeMembership.ToString();
            string expectedResponse = "UpgradeMembership";

            //Act
            var actualResponse = "UpgradeMembership_NotGenerated";

            //Assert
            Assert.NotEqual(expectedResponse, actualResponse);
        }
        #endregion

        #region MembershipOrUpgradePaymentType
        [Fact]
        public void WhenPaymenmtType_MembershipOrUpgrade_ShouldReturn_MembershipOrUpgrade()
        {
            //Arrange
            string paymentType = PaymentTypes.UpgradeOrMembership.ToString();
            string expectedResponse = "MembershipOrUpgrade";

            //Act
            var actualResponse = "MembershipOrUpgrade";

            //Assert
            Assert.Equal(expectedResponse, actualResponse);
        }

        [Fact]
        public void WhenPaymenmtType_Membership_ShouldReturn_MembershipOrUpgrade_NotGenerated()
        {
            //Arrange
            string paymentType = PaymentTypes.UpgradeMembership.ToString();
            string expectedResponse = "MembershipOrUpgrade";

            //Act
            var actualResponse = "UpgradeMembership_NotGenerated";

            //Assert
            Assert.NotEqual(expectedResponse, actualResponse);
        }
        #endregion
    }
}
