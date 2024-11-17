using MathUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilsUnitTests
{

    [TestFixture]
    public class LargestTest

    {
        [Test]
        public void Test_WhenTheLargestValueInArrayIsEqualToExpectedValue()
        {
           MathLib lib = new MathLib();
           int [] array = new int[3];
            array[0] = 8;
            array[1] = 10;
            array[2] = 7;
            Assert.That(lib.Largest(array), Is.EqualTo(9));
        }
    }
}
