using Testing_demo;

namespace TestingUsingMTest
{
    [TestClass]
    public sealed class Test1
    {
        // we give any name to method 
        //[TestMethod] attribute to indicate the test method
        //Assert.AreEqual methd takes two argument actual value , expected value
        [TestMethod]
        public void Testadd()
        {
            Operation op = new Operation();
            int resultFromMethod = op.add(2, 4);
            Assert.AreEqual(6, resultFromMethod);
        }

        [TestMethod]
        public void TestSubstract()
        {
            Operation op = new Operation();
            int result = op.substract(4, 2);
            Assert.AreEqual(2, result);
        }



        [TestMethod]
        public void TestMultiply()
        {
            Operation op = new Operation();
            int result = op.multiply(2, 3);
            Assert.AreEqual(6, result);
        }


        // we give any name to method 
        //[TestMethod] attribute to indicate the test method


        [TestMethod]
        public void TestDivide()
        {
            Operation op = new Operation();
            int result = op.divide(3, 3);
            Assert.AreEqual(1, result);
        }



    }
}
