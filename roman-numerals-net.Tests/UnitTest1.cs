namespace roman_numerals_net.Tests
{
    [TestFixture]
    public class ArabicToRomanTests
    {
        [Test]
        public void ArabicToRoman_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            int input = 1984;
            string expectedOutput = "MCMLXXXIV";

            // Act
            string result = RomanNumerals.ToRoman(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ArabicToRoman_LessThanZero_ThrowsArgumentException()
        {
            // Arrange
            int input = -320;

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => RomanNumerals.ToRoman(input));
        }

        [Test]
        public void ArabicToRoman_MoreThanMax_ThrowsArgumentException()
        {
            // Arrange
            int input = 1400999;

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => RomanNumerals.ToRoman(input));
        }

        [Test]
        public void ArabicToRoman_NullInput_ReturnsEmptyString()
        {
            // Arrange
            int input = 0;

            // Act & Assert
            Assert.IsEmpty(RomanNumerals.ToRoman(input));
        }

        [Test]
        public void ArabicToRoman_LowerBoundary_ReturnsI()
        {
            // Arrange
            int input = 1;
            string expectedOutput = "I";

            // Act
            string result = RomanNumerals.ToRoman(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ArabicToRoman_UpperBoundary_ReturnsMMMCMXCIX()
        {
            // Arrange
            int input = 3999;
            string expectedOutput = "MMMCMXCIX";

            // Act
            string result = RomanNumerals.ToRoman(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ArabicToRoman_EdgeCase_ReturnsCDXLIX()
        {
            // Arrange
            int input = 449;
            string expectedOutput = "CDXLIX";

            // Act
            string result = RomanNumerals.ToRoman(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ArabicToRoman_EdgeCase_ReturnsXCIX()
        {
            // Arrange
            int input = 99;
            string expectedOutput = "XCIX";

            // Act
            string result = RomanNumerals.ToRoman(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ArabicToRoman_EdgeCase_ReturnsMCMXCIX()
        {
            // Arrange
            int input = 1999;
            string expectedOutput = "MCMXCIX";

            // Act
            string result = RomanNumerals.ToRoman(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ArabicToRoman_EdgeCase_ReturnsCMXCIX()
        {
            // Arrange
            int input = 999;
            string expectedOutput = "CMXCIX";

            // Act
            string result = RomanNumerals.ToRoman(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }

    [TestFixture]
    public class RomanToArabicTests
    {
        [Test]
        public void RomanToArabic_ValidInput_ReturnsCorrectResult()
        {
            // Arrange
            string input = "MCMLXXXIV";
            int expectedOutput = 1984;

            // Act
            int result = RomanNumerals.ToInt(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void RomanToArabic_NullInput_ReturnsZero()
        {
            // Arrange
            string input = "";

            // Act
            int result = RomanNumerals.ToInt(input);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void RomanToArabic_MoreThanMax_ThrowsArgumentException()
        {
            // Arrange
            string input = "MMMMM";

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => RomanNumerals.ToInt(input));
        }

        [Test]
        public void RomanToArabic_InvalidInput_ThrowsArgumentException()
        {
            // Arrange
            string input = "ZXC";

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => RomanNumerals.ToInt(input));
        }

        [Test]
        public void RomanToArabic_LowerBoundary_Returns1()
        {
            // Arrange
            string input = "I";
            int expectedOutput = 1;

            // Act
            int result = RomanNumerals.ToInt(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void RomanToArabic_UpperBoundary_Returns3999()
        {
            // Arrange
            string input = "MMMCMXCIX";
            int expectedOutput = 3999;

            // Act
            int result = RomanNumerals.ToInt(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void RomanToArabic_EdgeCase_Returns449()
        {
            // Arrange
            string input = "CDXLIX";
            int expectedOutput = 449;

            // Act
            int result = RomanNumerals.ToInt(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void RomanToArabic_EdgeCase_Returns99()
        {
            // Arrange
            string input = "XCIX";
            int expectedOutput = 99;

            // Act
            int result = RomanNumerals.ToInt(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void RomanToArabic_EdgeCase_Returns1999()
        {
            // Arrange
            string input = "MCMXCIX";
            int expectedOutput = 1999;

            // Act
            int result = RomanNumerals.ToInt(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void RomanToArabic_EdgeCase_Returns999()
        {
            // Arrange
            string input = "CMXCIX";
            int expectedOutput = 999;

            // Act
            int result = RomanNumerals.ToInt(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}