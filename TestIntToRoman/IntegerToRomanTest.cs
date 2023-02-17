using IntToRoman_Sol1; 
using NUnit.Framework;
namespace TestIntToRoman
{
    public class IntegerToRomanTest
    {
        private OnesRomanExpression OnesRomanExpression_equaltest { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            OnesRomanExpression_equaltest = new OnesRomanExpression();
        }

        [Test]
        public void OnesRomanExpression_EqualTest()
        {
            //Assign
            int integer = 8;
            var context = new Context(integer);



            //Act

             OnesRomanExpression_equaltest.Interpret(context);

            //Assert
            Assert.Pass();
        }
    }
}