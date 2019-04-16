﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BoxProblems.Graphing
{
    internal class Node<N, E> : INode
    {
        public readonly N Value;
        public readonly List<Edge<N, E>> Edges = new List<Edge<N, E>>();

        public Node(N value)
        {
            this.Value = value;
        }

        public void AddEdge(Edge<N, E> edge)
        {
            Edges.Add(edge);
        }

        public IEnumerable<INode> GetNodeEnds()
        {
            foreach (var edge in Edges)
            {
                yield return edge.End;
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}