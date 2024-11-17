using MathUtils;

namespace MathUtilsUnitTests
{
    [TestFixture]
    //đánh dấu class kiểm thử.
    public class MathLibTests
    {
        [Test]

        public void Add_WhenProvideTwoPositiveNumbers_ReturnSum()
        {
            MathLib lib = new MathLib();
            int result = lib.Add(1, 2);
            int expected = -1;

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
     
        public void Add_WhenGivenNegativeTwoNumbers_ReturnSum()
        {
            MathLib lib = new MathLib();
            int result = lib.Subtract(1, 2);
            int expected = 3;

            Assert.That(result, Is.EqualTo(expected));
        }


    }
}