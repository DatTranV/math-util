namespace MathUtilsUnitTests
{
    [TestFixture]
    public class NunitAssert
    {
        [Test, Order(2)] //them order neu muon xet thu tu thuc hien
        public void Assert_AreEqual()
        {
            Assert.AreEqual(4, 5);
        }
        [Test, Order(1)]
        public void Assert_AreNotEqual()
        {
            Assert.AreNotEqual(5, 5);
        }
        [Test]
        public void Assert_IsTrue()
        {
            Assert.IsTrue(4 == 5);
        }

        [Test]
        public void Assert_IsFalse()
        {
            Assert.IsFalse(5 == 5);
        }

        [Test]
        public void Assert_IsNull()
        {
            String text = "hah";
            Assert.IsNull(text);

        }

        [Test]
        public void Assert_IsNotNull()
        {
            String text = null;
            Assert.IsNotNull(text);
        }

        [Test]
        public void Assert_Less()
        {
            Assert.Less(5, 4);
        }

        [TestCase(3, 5)]
        [TestCase(5, 3)]
        [TestCase(5, 5)]
        public void Assert_Greater(int a, int b)
        {
            Assert.Greater(a, b);
        }




    }
}
