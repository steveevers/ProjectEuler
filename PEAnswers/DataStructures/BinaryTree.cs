using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAnswers.DataStructures
{
    public class BinaryTree<T>
    {
        public BinaryTree<T> Parent;
        public BinaryTree<T> Left;
        public BinaryTree<T> Right;
        public T Value;

        public BinaryTree() { }
        public BinaryTree(T value)
        {
            this.Value = value;
        }
        public BinaryTree(BinaryTree<T> parent, T value)
            : this(value)
        {
            this.Parent = parent;
        }
    }
}
