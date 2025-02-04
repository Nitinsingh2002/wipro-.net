using Testing_demo;

namespace TestingUsingXunit
{
    public class UnitTest1
    {
        //here fact is attribute
        [Fact]
        public void TestAdd()
        {

            //Arrange 
            Operation op = new Operation();
            //act
            int result = op.add(2, 4);
            //assert
            Assert.Equal(6, result);
        }


        [Fact]
        public void testSubstract()
        {
            Operation op = new Operation();
            int result = op.substract(4, 2);
            Assert.Equal(2, result);
                 
        }


    }
}