using FluentAssertions;
using leetcode.arrays_and_hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground_test.leetcode_tests.arrays_and_hashing_tests
{
    public class GroupAnagramsTest
    {

        [Fact]
        public void ArraysAndHashing_GroupAnagrams()
        {
            //Arrange
            GroupAnagrams obj = new GroupAnagrams();

            //Act
            string[] s1 = {"eat", "tea", "tan", "ate", "nat", "bat"};
            string[] s2 = { "" };
            string[] s3 = { "a" };

            var testCase1Result = obj.solution(s1);
            var testCase2Result = obj.solution(s2);
            var testCase3Result = obj.solution(s3);

            //Assert
            IList<IList<string>> res1 = new List<IList<string>>
            {
                new List<string> { "bat" },
                new List<string> { "nat", "tan" },
                new List<string> { "ate", "eat", "tea" }
            };

            var testCase1Strings = testCase1Result.Select(x => string.Join(',', x.OrderBy(y => y))).OrderBy(z => z).ToList();
            var res1Strings = res1.Select(x => string.Join(',', x.OrderBy(y => y))).OrderBy(z => z).ToList();

            testCase1Strings.Should().Equal(res1Strings);
        }
    }
}
