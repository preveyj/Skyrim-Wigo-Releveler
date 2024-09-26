using EnemyReleveler.DefaultValues;
using EnemyReleveler.Enums;
using EnemyReleveler.LevelRanges;
using EnemyReleveler.Selectors;
using FluentAssertions;

namespace EnemyReleveler.Tests.Selectors
{
    [TestClass]
    public class LevelRangeSelectorTests
    {
        private LevelRangeSelector GetDefaultLevelRangeSelector()
        {
            return new LevelRangeSelector();
        }

        [TestMethod]
        public void GetLevelRangeBySelection_DoesNotReturnNull()
        {
            // Arrange
            var subject = GetDefaultLevelRangeSelector();
            var rangeChoicesList = Enum.GetValues<RangeChoices>().ToList();

            // Act
            foreach (var choice in rangeChoicesList)
            {
                var result = subject.GetLevelRangeBySelection(choice);
                result.Should().NotBeNull();
            }
        }

        [TestMethod]
        public void GetLevelRangeBySelection_DefaultSelected_ReturnsDefault()
        {
            //Arrange
            var subject = GetDefaultLevelRangeSelector();

            //Act
            var result = subject.GetLevelRangeBySelection(RangeChoices.Default);

            //Assert
            result.Should().BeOfType<DefaultLevelRanges>();
        }

        [TestMethod]
        public void GetLevelRangeBySelection_GracaSelected_ReturnsGraca()
        {
            //Arrange
            var subject = GetDefaultLevelRangeSelector();

            //Act
            var result = subject.GetLevelRangeBySelection(RangeChoices.Graca98);

            //Assert
            result.Should().BeOfType<Graca98Ranges>();
        }

        [TestMethod]
        public void GetLevelRangeBySelection_CustomSelected_ReturnsCustom()
        {
            //Arrange
            var subject = GetDefaultLevelRangeSelector();

            //Act
            var result = subject.GetLevelRangeBySelection(RangeChoices.Custom);

            //Assert
            result.Should().BeOfType<CustomLevelRanges>();
        }

        [TestMethod]
        public void GetLevelRangesBySelection_VanillaSelected_ReturnsVanilla()
        {
            //Arrange
            var subject = GetDefaultLevelRangeSelector();

            //Act
            var result = subject.GetLevelRangeBySelection(RangeChoices.Vanilla);

            //Assert
            result.Should().BeOfType<VanillaRanges>();
        }
    }
}
