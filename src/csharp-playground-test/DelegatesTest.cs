using csharp_playground.playground;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground_test
{
    public class DelegatesTest
    {
        [Fact]
        public void DelegatesTest_CalculateSquare() { 
            //Arrange
            DelegatesTutorial d = new DelegatesTutorial();

            //Act 
            int num = 5;
            int squareRes;
            bool boolRes;
            d.calculateSquare(num, out squareRes,out boolRes);

            //Assert
            squareRes.Should().Be(num * num);
            boolRes.Should().BeTrue();

        }
    }
}
