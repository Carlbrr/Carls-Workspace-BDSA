using System;
using Xunit;
using System.IO;


namespace HelloThere.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void IsLeap_True_If_Divisible_By_Four()
        {

            bool actual = Program.isLeapYear(4);

            //Assert
            //var output = writer.GetStringBuilder().ToString();
            Assert.Equal(true , actual);
        }
        
        [Fact]
        public void IsLeap_When_Not_Divisible_By_100()
        {
            Program.Main(new string[0]);

            bool result = Program.isLeapYear(1900);

            Assert.Equal(false,result);

        }

        [Fact]
        public void IsLeapYear_Exactly_When_Divisible_By_400()
        {
        //Given
        Program.Main(new string[0]);
        //When
        bool result = Program.isLeapYear(1600);

        //Then
        Assert.Equal(true,result);

        }
    }
}
