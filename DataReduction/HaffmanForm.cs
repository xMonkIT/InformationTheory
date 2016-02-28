using System.Windows.Forms;

namespace DataReduction
{
    public partial class HaffmanForm : Form
    {
        public HaffmanForm(HaffmanTree tree)
        {
            InitializeComponent();
            if (tree.Root != null) TreeBypass(tree.Root, tvHaffmanTree.Nodes.Add(""));
            tvHaffmanTree.ExpandAll();
        }

        private static void TreeBypass(HaffmanTree.HaffmanTreeNode root, TreeNode node)
        {
            while (true)
            {
                if (root.Left == null)
                {
                    node.Text = $"\"{root.Value}\" ({root.Weight}) - {node.FullPath}";
                    return;
                }
                TreeBypass(root.Left, node.Nodes.Add("0"));
                root = root.Right;
                node = node.Nodes.Add("1");
            }
        }
    }
}
