using System.Threading.Tasks;
using Xunit;

namespace BusinessRuleEngineTests
{
    public class RuleEngineTest
    {
        [Fact]
        public async Task WhenPaymenmtType_NULL_ShouldReturnEmpty()
        {
            //Arrange
            string paymentType = string.Empty;

            //Act
            var response = string.Empty;

            //Assert
            Assert.NotNull(response);
            
        }
    }
}
