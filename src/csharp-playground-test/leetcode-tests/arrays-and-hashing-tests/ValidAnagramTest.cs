using FluentAssertions;
using leetcode.arrays_and_hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground_test.leetcode_tests.arrays_and_hashing_tests
{
    public class ValidAnagramTest
    {
        [Fact]
        public void ArraysAndHashing_ValidAnagram()
        {
            //Arrange
            ValidAnagram obj = new ValidAnagram();

            //Act
            string s1 = "anagram", t1 = "nagaram";
            string s2 = "rat", t2 = "car";

            bool testCase1Result = obj.solution(s1,t1);
            bool testCase2Result = obj.solution(s2,t2);
            
            //Assert
            testCase1Result.Should().Be(true);
            testCase2Result.Should().Be(false);
        }
    }
}
