using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpStarterPack.PuzzleInputs;
using CSharpStarterPack.Days;

namespace Tests
{
    //[TestClass]
    public class Day20Tests
    {
        private readonly int day = 20;
        [TestMethod]
        public void Puzzle_A()
        {
            // Assign
            string expected = "";
            string input = PuzzleInput.GetInputAsText(day);

            // Act
            var actual = Day20.PuzzleA();

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Puzzle_B()
        {
            // Assign
            // Act
            // Assert
            Assert.AreEqual(1, 1);
        }
    }
}
