using Xunit;

namespace CSharp101.Exercices.Fundamentals
{
    public class VariablesExercices
    {
        [Fact]
        public void SimpleStringVariable()
        {
            // Create a new string variable called 'value' and have its content equal to 'This is a string value'


            #region Validation
            Assert.Equal("This is a string value", value);
            #endregion
        }

        [Fact]
        public void SimpleBooleanVariable()
        {
            // Create a new bool variable called 'value' and let it have the value 'true'
            

            #region Validation
            Assert.Equal(true, value);
            #endregion
        }

        [Fact]
        public void SimpleIntVariable()
        {
            // Create a new int variable called 'value' and let it have the value '14'
            

            #region Validation
            Assert.Equal(14, value);
            #endregion
        }

        [Theory]
        #region InlineData
        [InlineData("This is a string value")]
        [InlineData("This is a another string value")]
        [InlineData("This is, once more, another string value")]
        #endregion
        public void ParameterVariable(string parameter)
        {
            // Create a new string variable called 'value' and let it have the same value as the 'parameter' variable.
            

            #region Validation
            Assert.Equal(parameter, value);
            #endregion
        }
    }
}
