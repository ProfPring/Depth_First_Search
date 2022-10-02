using System;
using System.Collections.Generic;
using System.Text;

namespace Depth_First_Search
{
    public class aglorithems
    {
        public HashSet<T> DFS<T>(Graph<T> graph, T start)
        {
            var vivisted = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start))
            {
                return vivisted;
            }

            var stack = new Stack<T>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();

                if (vivisted.Contains(vertex))
                {
                    continue;
                }
                vivisted.Add(vertex);

                foreach (var neighbor in graph.AdjacencyList[vertex])
                {
                    if (!vivisted.Contains(neighbor))
                    {
                        stack.Push(neighbor);
                    }
                }
            }

           return vivisted;
        }
    }
}
