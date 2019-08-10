using NUnit.Framework;

namespace FizzBuzzBad.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_When1_Returns1()
        {
            // Arrange
            int input = 1;

            // Act
            string output = FizzBuzzerBad.GetValue(input);

            // Assert
            Assert.AreEqual("1", output);
        }

        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(2,4,7,8,11,13,14,16,17,19)]int input)
        {

            // Act
            string output = FizzBuzzerBad.GetValue(input);

            // Assert
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_WhenDiv3_Returns_Fizz([Values(3,6,9,12,18)] int input)
        {
            // Act
            string output = FizzBuzzerBad.GetValue(input);

            // Assert
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_WhenDiv5_Returns_Buzz([Values(5,10,20)] int input)
        {
            // Act
            string output = FizzBuzzerBad.GetValue(input);

            // Assert
            Assert.AreEqual("Buzz", output);
        }
        [Test]
        public void Buzzer_When_Div3_and_Div5_Returns_FizzBuzz([Values(15)] int input)
        {
            // Act
            string output = FizzBuzzerBad.GetValue(input);

            // Assert
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}