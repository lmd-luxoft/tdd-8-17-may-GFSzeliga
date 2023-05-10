using TDDKataCalc;

namespace TDDKata2
{
    public class UnitTest1
    {

        [Fact]
        public void EmptyStringTest()
        {

                //arrange
                var emptyString = "";
                var expectedResult = 0;
                var calc = new Calc();

                //act
                var result = calc.Add(emptyString);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        void OneDigitStringTest()
        {
            //arrange
            var emptyString = "1";
            var expectedResult = 1;
            var calc = new Calc();

            //act
            var result = calc.Add(emptyString);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        void TwoDigitStringTest()
        {
            //arrange
            var emptyString = "12";
            var expectedResult = 3;
            var calc = new Calc();

            //act
            var result = calc.Add(emptyString);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Theory()]
        [InlineData("a")]
        [InlineData(" ")]
        void StringIsNotDigitTest(string inlineData)
        {
            //arrange
            var emptyString = "a";
            var calc = new Calc();

            //assert
            Assert.Throws<NotImplementedException>(() => calc.Add(inlineData));
        }

        [Fact]
        void StringIsNotOnlyDigitTest()
        {
            //arrange
            var emptyString = "1a";
            var calc = new Calc();

            //assert
            Assert.Throws<NotImplementedException>(() => calc.Add(emptyString));
        }

        [Fact]
        void StringHasMoreThan2DigitsTest()
        {
            //arrange
            var emptyString = "123";
            var calc = new Calc();

            //assert
            Assert.Throws<NotImplementedException>(() => calc.Add(emptyString));
        }

        [Fact]
        void StringIsFloatNumberTypeTest()
        {
            //arrange
            var emptyString = "1.1";
            var calc = new Calc();

            //assert
            Assert.Throws<NotImplementedException>(() => calc.Add(emptyString));
        }


        [Fact]
        void NullIsPassedAsArgumentTest()
        {
            //arrange
            string? emptyString = null;
            var calc = new Calc();

            //assert
            Assert.Throws<NotImplementedException>(() => calc.Add(emptyString));
        }
    }
}