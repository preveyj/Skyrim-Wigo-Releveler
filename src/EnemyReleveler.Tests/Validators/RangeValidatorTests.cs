using EnemyReleveler.Models;
using EnemyReleveler.Validators;
using FluentAssertions;

namespace EnemyReleveler.Tests.Validators
{
    [TestClass]
    public class RangeValidatorTests
    {
        private RangeValidator GetDefaultRangeValidator()
        {
            return new RangeValidator();
        }

        [TestMethod]
        public void ValidateList_NormalInput_ReturnsTrue()
        {
            // Arrange
            var subject = GetDefaultRangeValidator();
            Dictionary<string, LevelRange> normalList = new Dictionary<string, LevelRange>() {
                { "test1", new LevelRange(0,0) }
            };

            // Act
            var result = subject.ValidateList(normalList);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ValidateList_InputHasNegativeMinimumLevel_ReturnsFalse()
        {
            //Arrange
            var subject = GetDefaultRangeValidator();
            Dictionary<string, LevelRange> negativeMinimumLevel = new Dictionary<string, LevelRange>() {
                { "test1", new LevelRange(-1,0) }
            };

            //Act
            var result = subject.ValidateList(negativeMinimumLevel);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void ValidateList_InputHasNegativeMaxLevel_ReturnsFalse()
        {
            //Arrange
            var subject = GetDefaultRangeValidator();
            Dictionary<string, LevelRange> negativeMaxLevel = new Dictionary<string, LevelRange>() {
                { "test1", new LevelRange(-2,-1) }
            };

            //Act
            var result = subject.ValidateList(negativeMaxLevel);

            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void ValidateList_InputHaInvertedLevels_ReturnsFalse()
        {
            //Arrange
            var subject = GetDefaultRangeValidator();
            Dictionary<string, LevelRange> invertedLevels = new Dictionary<string, LevelRange>() {
                { "test1", new LevelRange(5,4) }
            };

            //Act
            var result = subject.ValidateList(invertedLevels);

            //Assert
            result.Should().BeFalse();
        }
    }
}
