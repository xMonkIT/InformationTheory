using System.Collections.Generic;

namespace DataReduction
{
    public class HaffmanTree
    {
        public class HaffmanTreeNode
        {
            public HaffmanTreeNode Left { get; set; }
            public HaffmanTreeNode Right { get; set; }
            public char? Value { get; }
            public int Weight { get; }

            public HaffmanTreeNode(char ch, int fr)
            {
                Value = ch;
                Weight = fr;
            }

            public HaffmanTreeNode(int fr, HaffmanTreeNode left, HaffmanTreeNode right)
            {
                Weight = fr;
                Left = left;
                Right = right;
            }
        }

        public HaffmanTreeNode Root { get; }

        public HaffmanTree(Alphabet alphabet)
        {
            var list = new List<HaffmanTreeNode>();

            foreach (Alphabet.AlphabetChar ch in alphabet) list.Add(new HaffmanTreeNode(ch.Char, ch.Frequency));

            while (list.Count > 1)
            {
                list.Sort((x, y) => x.Weight.CompareTo(y.Weight));
                list.Add(new HaffmanTreeNode(list[0].Weight + list[1].Weight, list[0], list[1]));
                list.RemoveRange(0, 2);
            }

            if (list.Count > 0) Root = list[0];
        }

        private string Post(char ch, HaffmanTreeNode root, string buff)
        {
            if (root.Value == ch) return buff;
            if (root.Left != null)
            {
                var str = Post(ch, root.Left, $"{buff}0");
                if (str != "") return str;
                str = Post(ch, root.Right, $"{buff}1");
                return str;
            }
            return "";
        }

        public string GetCharCode(char ch) => Post(ch, Root, "");
    }
}
