using BusinessRuleEngine.Implementation;
using BusinessRuleEngine.Interface;

namespace BusinessRuleEngine
{
    public class ResolveStrategyByPaymentType
    {
        public IOrderProcessing ResolveStrategy(string paymentType)
        {
            if (paymentType == PaymentTypes.Book.ToString())
            {
                return new RoyalityDepartmentSlip();
            }
            
            if (paymentType == PaymentTypes.LearningToSkiVideo.ToString())
            {
                return new LearningToSkiVideo();
            }
            
            if (paymentType == PaymentTypes.Membership.ToString())
            {
                return new Membership();
            }
            
            if (paymentType == PaymentTypes.PhysicalProduct.ToString())
            {
                return new GenerateShippingSlip();
            }
            
            if (paymentType == PaymentTypes.PhysicalProductOrBook.ToString())
            {
                return new GenerateCommissionPayment();
            }
            
            if (paymentType == PaymentTypes.UpgradeMembership.ToString())
            {
                return new UpgradeMembership();
            }
            
            if (paymentType == PaymentTypes.UpgradeOrMembership.ToString())
            {
                return new MembershipOrUpgrade();
            }

            return new RoyalityDepartmentSlip();
        }
    }
}
