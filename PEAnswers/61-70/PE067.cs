using PEAnswers.DataStructures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers
{
    public static class PE067
    {
        public static long Answer()
        {
            var lines = File.ReadAllLines(@"Data\PE067.txt");
            var graph = lines.Select(l => l.Split(new char[] { ' ' }).Select(c => int.Parse(c)).ToList()).ToList();
            var root = Construct(graph, 0, 0);

            SumPaths(root, 0);

            return paths.Max();
        }

        private static List<int> paths = new List<int>();
        private static void SumPaths(BinaryTree<int> tree, int sum)
        {
            sum += tree.Value;

            if (tree.Left == null && tree.Right == null)
            {
                paths.Add(sum);
            }
            else
            {
                if (tree.Left != null) SumPaths(tree.Left, sum);
                if (tree.Right != null) SumPaths(tree.Right, sum);
            }
        }

        private static BinaryTree<int> Construct(List<List<int>> graph, int row, int col, BinaryTree<int> parent = null)
        {
            var tree = new BinaryTree<int>(parent, graph[row][col]);

            if (row < graph.Count() - 1)
            {
                tree.Left = Construct(graph, row + 1, col, tree);
                tree.Right = Construct(graph, row + 1, col + 1, tree);
            }

            return tree;
        }
    }
}
