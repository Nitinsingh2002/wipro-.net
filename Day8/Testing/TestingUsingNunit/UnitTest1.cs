using Moq;
using Testing_demo;

namespace TestingUsingNunit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //AAA  arrange act  assert


        // in Nunit [Test] is attribute
        [Test]
        public void TestAdd()
        {
            //Arrange
            Operation op = new Operation();
            //act
            int result = op.add(2, 4);
            //assert
            Assert.AreEqual(6,result);
        }

        [Test]
        public void TestSubstract()
        {
            Operation op = new Operation();
            int result = op.substract(4, 2);
            Assert.AreEqual(2, result);
        }



        //testing add using Moq
        //we can test using static data
        [Test]
        public void TestUsingMoq()
        {
            //Arrange
            //creating object of Moq
            Mock<Operation> m = new Mock<Operation>();
            m.Setup(x => x.add(2,4)).Returns(6);

            
            //act
            int result = m.Object.add(2, 4);


            // result is actual result
            //Assert
            Assert.AreEqual(6, result);


        }




        //testing another method Chack value using moq
        [Test]
        public void TestCheckValue()
        {
            // Arrange
            Mock<Operation> m = new Mock<Operation>();

            // This line means that when checkValue() is called on the mocked object,
            // it will return false without actually executing any real implementation.
            // Moq bypasses the actual method call and returns the predefined value (false).
            m.Setup(x => x.checkValue()).Returns(false);

            // Act 
            bool result = m.Object.checkValue();

            // Assert
            // The expected result is false, and we verify that the mocked method returns it.
            Assert.AreEqual(false, result);
        }


        //testing a method with multiple  test case 
        [Test]
        //first test case
        [TestCase(10,20,30)]
        //second test case
        [TestCase(10,30,40)]

        public void TestAddMethod(int a, int b, int actual)
        {
            //Arrange
            Operation op = new Operation();

            //act 
            int result = op.add(a, b);
            Assert.AreEqual(actual, result);
        }

    }
}