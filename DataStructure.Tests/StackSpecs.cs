using DataStructure.Stack;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructure.Tests
{
    public class StackSpecs
    {
        [Fact]
        public void Stack_by_linkedlist_should_work_correct()
        {
            StacksLinkedList stc = new();
            stc.Push(3);
            stc.Push(12);
            stc.Push(1);
            var result = stc.Display();
            result.Should().Be("1=>12=>3=>");
            (stc.Top()).Should().Be(1);

            var length = stc.Length();
            length.Should().Be(3);

            var popedRes = stc.Pop();
            popedRes.Should().Be(1);

            result = stc.Display();
            result.Should().Be("12=>3=>");

            stc.Push(9);

            result = stc.Display();
            result.Should().Be("9=>12=>3=>");
            stc.Pop();
            stc.Pop();
            stc.Pop();
            popedRes = stc.Pop();

            popedRes.Should().Be(-1);
            (stc.Top()).Should().Be(-1);
        }


        [Fact]
        public void Stack_by_Array_should_work_correct()
        {
            StacksArray stc = new(3);
            stc.Push(3);
            stc.Push(12);
            stc.Push(1);
            var result = stc.Display();
            result.Should().Be("3=>12=>1=>");

            var length = stc.Length();
            length.Should().Be(3);

            var popedRes = stc.Pop();

            popedRes.Should().Be(1);

            result = stc.Display();
            result.Should().Be("3=>12=>");

            stc.Push(9);

            result = stc.Display();
            result.Should().Be("3=>12=>9=>");
        }

        [Theory]
        [InlineData(true, '{', '}')]
        [InlineData(false, '{', ')')]
        [InlineData(false, '{')]
        [InlineData(false, '(', ']')]
        [InlineData(false, '(', '}')]
        [InlineData(false, ')')]
        [InlineData(true, '{', '(', ')', '}', '[', ']')]
        [InlineData(true, '{', '[', '{', '}', ']', '}')]
        public void Balanced_brackets(bool result, params char[] brackets)
        {
            var areBalanced = BalancedBracket.AreBracketsBalanced(brackets);
            areBalanced.Should().Be(result);

        }
    }
}
