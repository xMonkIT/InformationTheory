using System.Windows.Forms;

namespace DataReduction
{
    public partial class HaffmanForm : Form
    {
        class HaffmanTreeViewNode : TreeNode
        {
            public HaffmanTree.HaffmanTreeNode Value { get; }

            public HaffmanTreeViewNode(string text, HaffmanTree.HaffmanTreeNode node) : base(text)
            {
                Value = node;
            }
        }

        public HaffmanForm(HaffmanTree tree)
        {
            InitializeComponent();
            if (tree.Root != null) TreeBypass(tree.Root, tvHaffmanTree.Nodes.Add(""));
        }

        private void TreeBypass(HaffmanTree.HaffmanTreeNode root, TreeNode node)
        {
            if (root.Left == null)
            {
                node.Text = $"\"{root.Value}\" ({root.Weight}) - {node.FullPath}";
                return;
            }
            TreeBypass(root.Left, node.Nodes.Add("0"));
            TreeBypass(root.Right, node.Nodes.Add("1"));
        }
    }
}
