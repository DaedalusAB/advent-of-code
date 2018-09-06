using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace advent_2_checksum
{
    public class SpreadsheetChecksumTests
    {
        [Theory]
        [MemberData(nameof(FindMinMaxDifferenceInArrayCases))]
        public void FindMinMaxDifferenceInArray(int[] array, int minMaxDifference)
        {
            Assert.Equal(minMaxDifference, SpreadsheetChecksum.FindMinMaxDifferenceFor(array));
        }


        [Theory]
        [MemberData(nameof(TestSpreadsheetChecksumCases))]
        public void TestSpreadsheetChecksum(List<int[]> input, int solution)
        {
            Assert.Equal(solution, SpreadsheetChecksum.SolveFor(input));
        }

        [Fact]
        public void TestSolution()
        {
            var input = ReadFromFile("Input.txt");

            Assert.Equal(47136, SpreadsheetChecksum.SolveFor(input));
        }

        private List<int[]> ReadFromFile(string fileName)
        {
            var inputFileLines = File.ReadAllLines(fileName);
            var input = new List<int[]>();

            foreach (var inputLine in inputFileLines)
            {
                var lineValues = inputLine.Split(' ').Select(int.Parse).ToArray();
                input.Add(lineValues);
            }

            return input;
        }

        public static IEnumerable<object[]> FindMinMaxDifferenceInArrayCases()
        {
            yield return new object[] { new int[] { 5, 1, 9, 5 }, 8 };
            yield return new object[] { new int[] { 7, 5, 3 }, 4 };
            yield return new object[] { new int[] { 2, 4, 6, 8 }, 6 };
        }

        public static IEnumerable<object[]> TestSpreadsheetChecksumCases()
        {
            yield return new object[]
            {
                new List<int[]>()
                {
                    new int[] { 5, 1, 9, 5},
                    new int[] { 7, 5, 3 },
                    new int[] {2, 4, 6, 8 }
                },
                18
            };
        }
    }
}
