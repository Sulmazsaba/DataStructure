using DataStructure.Queues;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructure.Tests
{
    public class QueueSpecs
    {
        [Fact]
        public void Queues_by_Linked_list_work_correct()
        {
            QueuesLinkedList que = new QueuesLinkedList();

            que.Enqueue(5);
            que.Enqueue(10);
            que.Enqueue(15);
            que.Enqueue(2);

            var size = que.Length();
            size.Should().Be(4);

            var result = que.Display();
            result.Should().Be("5=>10=>15=>2=>");

            var number = que.Dequeue();
            number.Should().Be(5);

            result = que.Display();
            result.Should().Be("10=>15=>2=>");

            var first = que.First();
            first.Should().Be(10);

            que.Dequeue();
            que.Dequeue();
            que.Dequeue();

            number = que.Dequeue();
            number.Should().BeNegative();

            first = que.First();
            first.Should().Be(-1);
        }

        [Fact]
        public void Queues_by_array_work_fine()
        {
            QueuesArray que = new QueuesArray(5);

            que.Enqueue(5);
            que.Enqueue(10);
            que.Enqueue(15);
            que.Enqueue(2);

            var size = que.Length();
            size.Should().Be(4);

            var result = que.Display();
            result.Should().Be("5=>10=>15=>2=>");

            var number = que.Dequeue();
            number.Should().Be(5);

            result = que.Display();
            result.Should().Be("10=>15=>2=>");

            var first = que.First();
            first.Should().Be(10);

            que.Dequeue();
            que.Dequeue();
            que.Dequeue();

            number = que.Dequeue();
            number.Should().BeNegative();

            first = que.First();
            first.Should().Be(-1);
        }
    }
}
