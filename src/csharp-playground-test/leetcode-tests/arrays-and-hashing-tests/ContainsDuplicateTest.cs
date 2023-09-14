using FluentAssertions;
using leetcode.arrays_and_hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground_test.leetcode_tests.arrays_and_hashing_tests
{
    
    public class ContainsDuplicateTest
    {
        [Fact]
        public void ArraysAndHashing_ContainsDuplicate()
        {
            //Arrange
            ContainsDuplicate d = new ContainsDuplicate();

            //Act
            int[] testCase1 = { 1, 2, 3, 1 };
            int[] testCase2 = { 1, 2, 3, 4 };
            int[] testCase3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            bool testCase1Result = d.solution(testCase1);
            bool testCase2Result = d.solution(testCase2);
            bool testCase3Result = d.solution(testCase3);

            //Assert
            testCase1Result.Should().Be(true);
            testCase2Result.Should().Be(false);
            testCase3Result.Should().Be(true);
        }
    }
}
