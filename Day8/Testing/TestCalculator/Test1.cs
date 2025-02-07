using ClassLibrary1;

namespace TestCalculator
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator c = new Calculator();
            double result = c.Add(2.0, 2.0);
            Assert.AreEqual(4.0, result);
        }


        [TestMethod]
        public void Testsub()
        {
            Calculator c = new Calculator();
            double result = c.Subtract(2.0, 2.0);
            Assert.AreEqual(0.0, result);
        }



        [TestMethod]
        public void TestMulti()
        {
            Calculator c = new Calculator();
            double result = c.Multiply(2.0, 2.0);
            Assert.AreEqual(4.0, result);
        }

        [TestMethod]
        public void TestDiv()
        {
            Calculator c = new Calculator();
            double result = c.Divide(2.0, 2.0);
            Assert.AreEqual(1.0, result);
        }


        //testing divison method in case of exception 
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            Calculator c = new Calculator();
            c.Divide(4.0, 0.0);
        }



    }
}
