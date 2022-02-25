using DataStructure.StringManipulation;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructure.Tests
{
    public class StringManipulationSpecs
    {

        [Fact]
        public void String_manipulation_should_work_fine()
        {
            string word = "this is my world";
            var res = StringUtils.CountVowels(word);
            res.Should().Be(3);

            var result = StringUtils.Reverse("hello");
            result.Should().Be("olleh");


            //var isRotated = StringUtils.IsRotated("ABCD", "BCDD");
            //isRotated.Should().Be(false);

            //isRotated = StringUtils.IsRotated("AB", "BA");
            //isRotated.Should().Be(true);


            StringUtils.RemoveDuplicateChar(ref word);
            word.Should().Be("this myworld");

            var resultChar = StringUtils.GetMostRepeatedChar("thisismemyfriends");
            resultChar.Should().Be('i');

            //Console.WriteLine(StringUtils.Capitalize(word));
            //Console.WriteLine(StringUtils.AreAnagrams("SABa","BASA"));
            //Console.WriteLine(StringUtils.ArePalindrome("ABBAS"));
        }

    }
}
