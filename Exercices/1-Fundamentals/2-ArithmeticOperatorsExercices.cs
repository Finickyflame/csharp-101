using Xunit;

namespace CSharp101.Exercices.Fundamentals
{
    public class ArithmeticOperatorsExercices
    {
        [Theory]
        #region InlineData
        [InlineData(1, 2, 3)]
        [InlineData(2, 1, 3)]
        [InlineData(5, 10, 15)]
        [InlineData(12345, 654321, 666666)]
        #endregion
        public void AdditionOperator(int a, int b, int expectedResult)
        {
            // Change the 'value' variable to be equal to the addition of the variable 'a' by 'b'
            int value = 0;

            #region Validation
            Assert.Equal(expectedResult, value);
            #endregion
        }

        [Theory]
        #region InlineData
        [InlineData(4, 2, 3)]
        [InlineData(3, 1, 2)]
        [InlineData(5, 10, -5)]
        [InlineData(12345, 654321, -641976)]
        #endregion
        public void SubstractionOperator(int a, int b, int expectedResult)
        {
            // Change the 'value' variable to be equal to the substraction of the variable 'a' by 'b'
            int value = 0;

            #region Validation
            Assert.Equal(expectedResult, value);
            #endregion
        }
        
        [Theory]
        #region InlineData
        [InlineData(2, 2, 4)]
        [InlineData(3, 1, 3)]
        [InlineData(10, 5, 50)]
        [InlineData(14567, 530, 7720510)]
        #endregion
        public void MultiplicationOperator(int a, int b, int expectedResult)
        {
            // Change the 'value' variable to be equal to the multiplcation of the variable 'a' by 'b'
            int value = 0;

            #region Validation
            Assert.Equal(expectedResult, value);
            #endregion
        }
        
        [Theory]
        #region InlineData
        [InlineData(4, 2, 2)]
        [InlineData(3, 1, 3)]
        [InlineData(10, 5, 2)]
        [InlineData(7720510, 530,  14567)]
        #endregion
        public void DivisionOperator(int a, int b, int expectedResult)
        {
            // Change the 'value' variable to be equal to the division of the variable 'a' by 'b'
            int value = 0;

            #region Validation
            Assert.Equal(expectedResult, value);
            #endregion
        }
    }
}
