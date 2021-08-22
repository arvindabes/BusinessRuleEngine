using BusinessRuleEngine;
using BusinessRuleEngine.Interface;
using FakeItEasy;
using System.Threading.Tasks;
using Xunit;

namespace BusinessRuleEngineTests
{
    public class RuleEngineTest
    {        

        public RuleEngineTest()
        {
            
        }

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
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = orderProc.ProcessOrder();

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
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = "Invalid"+orderProc.ProcessOrder();

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
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = orderProc.ProcessOrder();

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
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = "Invalid" + orderProc.ProcessOrder();

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
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = orderProc.ProcessOrder();

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
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = "Invalid" + orderProc.ProcessOrder();

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
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = orderProc.ProcessOrder();

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
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = "Invalid" + orderProc.ProcessOrder();

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
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = orderProc.ProcessOrder();

            //Assert
            Assert.Equal(expectedResponse, actualResponse);
        }

        [Fact]
        public void WhenPaymenmtType_Membership_ShouldReturn_MembershipOrUpgrade_NotGenerated()
        {
            //Arrange
            string paymentType = PaymentTypes.UpgradeOrMembership.ToString();
            string expectedResponse = "MembershipOrUpgrade";

            //Act
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = "Invalid" + orderProc.ProcessOrder();

            //Assert
            Assert.NotEqual(expectedResponse, actualResponse);
        }
        #endregion

        #region LearningToSkiVideoPaymentType
        [Fact]
        public void WhenPaymenmtType_LearningToSkiVideo_ShouldReturn_FirstAddVideoToPackingSlip()
        {
            //Arrange
            string paymentType = PaymentTypes.LearningToSkiVideo.ToString();
            string expectedResponse = "FirstAddVideoToPackingSlip";

            //Act
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = orderProc.ProcessOrder();

            //Assert
            Assert.Equal(expectedResponse, actualResponse);
        }

        [Fact]
        public void WhenPaymenmtType_LearningToSkiVideo_ShouldReturn_FirstAddVideoToPackingSlip_NotGenerated()
        {
            //Arrange
            string paymentType = PaymentTypes.LearningToSkiVideo.ToString();
            string expectedResponse = "FirstAddVideoToPackingSlip";

            //Act
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = "Invalid" + orderProc.ProcessOrder();

            //Assert
            Assert.NotEqual(expectedResponse, actualResponse);
        }
        #endregion

        #region PhysicalProductOrBookPaymentType
        [Fact]
        public void WhenPaymenmtType_PhysicalProductOrBook_ShouldReturn_CommissionPaymentToAgent()
        {
            //Arrange
            string paymentType = PaymentTypes.PhysicalProductOrBook.ToString();
            string expectedResponse = "CommissionPaymentToAgent";

            //Act
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = orderProc.ProcessOrder();

            //Assert
            Assert.Equal(expectedResponse, actualResponse);
        }

        [Fact]
        public void WhenPaymenmtType_PhysicalProductOrBook_ShouldReturn_CommissionPaymentToAgent_NotGenerated()
        {
            //Arrange
            string paymentType = PaymentTypes.PhysicalProductOrBook.ToString();
            string expectedResponse = "CommissionPaymentToAgent";

            //Act
            ResolveStrategyByPaymentType strategy = new ResolveStrategyByPaymentType();
            IOrderProcessing orderProc = strategy.ResolveStrategy(paymentType);

            var actualResponse = "Invalid" + orderProc.ProcessOrder();

            //Assert
            Assert.NotEqual(expectedResponse, actualResponse);
        }
        #endregion
    }
}
