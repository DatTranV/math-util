using MathUtils;

namespace MathUtilsUnitTests
{

    [TestFixture]
    public class LargestTest

    {
        [Test]
        public void Test_WhenTheLargestValueInArrayIsEqualToExpectedValue()
        {
            MathLib lib = new MathLib();
            int[] array = new int[3];
            array[0] = 8;
            array[1] = 9;
            array[2] = 7;
            Assert.That(lib.Largest(array), Is.EqualTo(9));
        }
    }
}
