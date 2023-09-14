using FluentAssertions;
using leetcode.arrays_and_hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground_test.leetcode_tests.arrays_and_hashing_tests
{
    public class TwoSumTest
    {
        [Fact]
        public void ArraysAndHashing_TwoSum()
        {
            //Arrange
            TwoSum obj = new TwoSum();

            //Act
            int[] nums1 = { 2, 7, 11, 15 }; int t1 = 9;
            int[] nums2 = { 3, 2, 4 }; int t2 = 6;

            int[] testCase1Result = obj.solution(nums1, t1);
            int[] testCase2Result = obj.solution(nums2, t2);

            //Assert
            testCase1Result.Should().Equal(new[] { 0, 1 });
            testCase2Result.Should().Equal(new[] { 1, 2 });
        }
    }
}
