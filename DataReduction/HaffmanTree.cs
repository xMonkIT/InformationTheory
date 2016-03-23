using System.Collections.Generic;
using System.Linq;

namespace DataReduction
{
    public class HaffmanTree<T>
    {
        public class HaffmanTreeNode<TNode>
        {
            public HaffmanTreeNode<TNode> Left { get; }
            public HaffmanTreeNode<TNode> Right { get; }
            public TNode Value { get; }
            public int Weight { get; }

            public HaffmanTreeNode(TNode value, int fr)
            {
                Value = value;
                Weight = fr;
            }

            public HaffmanTreeNode(int fr, HaffmanTreeNode<TNode> left, HaffmanTreeNode<TNode> right)
            {
                Weight = fr;
                Left = left;
                Right = right;
            }
        }

        public HaffmanTreeNode<T> Root { get; }

        public HaffmanTree(IEnumerable<KeyValuePair<T, int>> keyValuePairs)
        {
            var list = keyValuePairs.Select(x => new HaffmanTreeNode<T>(x.Key, x.Value)).ToList();

            while (list.Count > 1)
            {
                list.Sort((x, y) => x.Weight.CompareTo(y.Weight));
                list.Add(new HaffmanTreeNode<T>(list[0].Weight + list[1].Weight, list[0], list[1]));
                list.RemoveRange(0, 2);
            }

            if (list.Count > 0) Root = list[0];
        }

        private static string Post(T value, HaffmanTreeNode<T> root, string buff)
        {
            if (root.Value.Equals(value)) return buff;
            if (root.Left == null) return "";
            var str = Post(value, root.Left, $"{buff}0");
            if (str != "") return str;
            str = Post(value, root.Right, $"{buff}1");
            return str;
        }

        public string GetCharCode(T value) => Post(value, Root, "");
    }
}
