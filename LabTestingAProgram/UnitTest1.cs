namespace LabTestingAProgram
{
    public class Tests
    {
        private BasicMath math;

        [SetUp]
        public void Setup()
        {
            this.math = new BasicMath();
        }

        [Test]
        public void Test_AddMethod()
        {
            double expected = 5;
            double actual = this.math.Add(2, 3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SubtractMethod()
        {
            double expected = 3;
            double actual = this.math.Subtract(6, 3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_DivideMethod()
        {
            double expected = 2;
            double actual = this.math.Divide(6, 3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_DivideByZero()
        {
            try
            {
                double actual = this.math.Divide(10, 0);

                Assert.Fail();
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }

        }

        [Test]
        public void Test_MultiplyMethod()
        {
            double expected = 8;
            double actual = this.math.Multiply(4, 2);

            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void Teardown()
        {
            this.math = null;
        }
    }
}