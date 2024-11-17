namespace MathUtilsUnitTests
{
    [TestFixture]
    public class NunitAssert
    {
        [Test, Order(2)] //them order neu muon xet thu tu thuc hien
        public void Assert_AreEqual()
        {
            Assert.AreEqual(5, 5);
        }
        [Test, Order(1)]
        public void Assert_AreNotEqual()
        {
            Assert.AreNotEqual(3, 5);
        }
        [Test]
        public void Assert_IsTrue()
        {
            Assert.IsTrue(5 == 5);
        }

        [Test]
        public void Assert_IsFalse()
        {
            Assert.IsFalse(3 == 5);
        }

        [Test]
        public void Assert_IsNull()
        {
            String text = null;
            Assert.IsNull(text);

        }

        [Test]
        public void Assert_IsNotNull()
        {
            String text = "null";
            Assert.IsNotNull(text);
        }

        [Test]
        public void Assert_Less()
        {
            Assert.Less(4, 40);
        }

        [TestCase(6, 5)]
        [TestCase(10, 3)]
        [TestCase(7, 5)]
        public void Assert_Greater(int a, int b)
        {
            Assert.Greater(a, b);
        }




    }
}
