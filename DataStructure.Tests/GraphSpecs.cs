using DataStructure.GraphsSolutions;
using Xunit;
using FluentAssertions;
using System;
using System.Collections.Generic;

namespace DataStructure.Tests
{
    public class GraphSpecs
    {
        [Fact]
        public void Add_node_and_edge_should_print_correct_result()
        {

            Graph graph = new Graph();

            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddEdge("A", "B");

            var result = string.Join("", graph.Print());
            result.Should().Be("A=>B");
        }

        [Fact]
        public void Add_edge_for_undefined_node_should_throw_exception()
        {
            var graph = new Graph();
            var action = () =>
            {
                graph.AddEdge("A", "B");
            };

            action.Should().Throw<KeyNotFoundException>();
        }

        [Fact]
        public void Remove_undefined_node_should_not_throw_exception()
        {
            var graph = new Graph();
            graph.RemoveNode("Jack");

            var result = string.Join("", graph.Print());
            result.Should().Be("");
        }

        [Fact]
        public void Remove_node_should_remove_node_and_edge_from_graph()
        {
            Graph graph = new Graph();

            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddEdge("A", "B");
            graph.RemoveNode("A");


            var result = string.Join("", graph.Print());
            result.Should().Be("");
        }

        [Fact]
        public void Remove_edge_should_remove_node_without_edge()
        {
            Graph graph = new Graph();

            graph.AddNode("John");
            graph.AddNode("Sub");
            graph.AddEdge("John", "Sub");

            graph.RemoveEdge("John", "Sub");

            var result = string.Join("", graph.Print());
            result.Should().Be("");
        }

        [Fact]
        public void Traverse_depth_first_and_breadth_first()
        {
            var graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddEdge("A", "B");
            graph.AddNode("C");
            graph.AddEdge("B", "C");
            graph.AddNode("D");
            graph.AddEdge("B", "D");


            graph.TraverseDepthFirst("B");
            graph.TraverseBreadthFirst("B");

        }

        [Fact]
        public void Graph_has_Cycle()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddEdge("A", "B");
            graph.AddNode("C");

            graph.AddEdge("B","C");
            graph.AddEdge("C", "A");

            var result =graph.HasCycle();
            result.Should().Be(true);   
        }

        [Fact]
        public void Graph_has_not_Cycle()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddEdge("A", "B");
            graph.AddNode("C");
            graph.AddEdge("A", "C");

            var result = graph.HasCycle();
            result.Should().Be(false);
        }

        [Fact]
        public void Topological_sort_should_return_correct_graph()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddEdge("A", "B");
            graph.AddNode("C");
            graph.AddEdge("A", "C");
            graph.AddNode("D");
            graph.AddEdge("C", "D");

            var result = graph.TopologicalSort();

            String.Join("", result).Should().Be("ACDB");
        }
    }
}