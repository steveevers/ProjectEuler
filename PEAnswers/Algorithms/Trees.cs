using PEAnswers.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers.Algorithms
{
    public static class Trees
    {
        public static IEnumerable<BinaryTree<T>> PreOrder<T>(this BinaryTree<T> tree)
            where T : IComparable<T>
        {
            yield return tree;

            if (tree.Left != null)
            {
                var l = PreOrder(tree.Left);
                foreach (var i in l)
                    yield return i;
            }

            if (tree.Right != null)
            {
                var r = PreOrder(tree.Right);
                foreach (var i in r)
                    yield return i;
            }
        }

        public static IEnumerable<BinaryTree<T>> InOrder<T>(this BinaryTree<T> tree)
            where T : IComparable<T>
        {
            if (tree.Left != null)
            {
                var l = InOrder(tree.Left);
                foreach (var i in l)
                    yield return i;
            }

            yield return tree;

            if (tree.Right != null)
            {
                var r = InOrder(tree.Right);
                foreach (var i in r)
                    yield return i;
            }
        }

        public static IEnumerable<BinaryTree<T>> PostOrder<T>(this BinaryTree<T> tree)
            where T : IComparable<T>
        {
            if (tree.Left != null)
            {
                var l = PostOrder(tree.Left);
                foreach (var i in l)
                    yield return i;
            }

            if (tree.Right != null)
            {
                var r = PostOrder(tree.Right);
                foreach (var i in r)
                    yield return i;
            }

            yield return tree;
        }
    }
}
