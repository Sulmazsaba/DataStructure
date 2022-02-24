using DataStructure.HashTableSolutions;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructure.Tests
{
    public class HashTableSpecs
    {
        [Theory]
        [InlineData("Hi This is ALi", 'i')]
        [InlineData("Hi", null)]
        public void Get_first_repeated_char(string statement, char? expectedRes)
        {
          var result = Problems.GetFirstRepeatedChar(statement.ToCharArray());
            result.Should().Be(expectedRes);
        }


        [Theory]
        [InlineData("HH", "Not Found")]
        [InlineData("HG", "H")]
        public void Get_non_repeated_char(string statement, string expectedRes)
        {

           var result = Problems.GetNonRepeatedChar(statement.ToCharArray());
           result.Should().Be(expectedRes);
        }

        [Fact]
        public void Hashtable_should_work_fine()
        {
            var table = new HashTable();
            table.Put(4, "Saba");
            table.Put(3, "Lagha");
            table.Put(12, "Sohrab");
            table.Put(4, "SS");
            table.Remove(12);

            var action = () => { table.Remove(12); };
            action.Should().Throw<InvalidOperationException>();

            var result = table.Get(4);
            result.Should().Be("SS");
        }
    }
}
