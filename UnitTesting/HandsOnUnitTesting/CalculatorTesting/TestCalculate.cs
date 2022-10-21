using CalculateService;
using NUnit.Framework;
namespace CalculatorTesting
{
    [TestFixture]
    public class TestCalculate
    {
        [SetUp]
        public void Setup()
        {
        }
        //Testcases

        [Test]
        public void TestAdd()
        {
           //Arragen
           Calculate calculate = new Calculate();
            int expected = 5;
            //Act
            int actual = calculate.Add(2, 3);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestAddFail()
        {
            //Arragen
            Calculate calculate = new Calculate();
            int expected = 15;
            //Act
            int actual = calculate.Add(2, 3);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestMul()
        {
            //Arrange
            Calculate calculate = new Calculate();
            int exprected = 20;
            //Act
            int actual = calculate.Mul(4, 5);
            //Assert
            Assert.Greater(actual, 0);
        }
        [Test]
        public void TestGetNumbers()
        {
            //Arrange
            Calculate calculate = new Calculate();

            //Act
            List<int> actual = calculate.GetNumbers();
            //Assert
            Assert.NotNull(actual);
        }
    }
}