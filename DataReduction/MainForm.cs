using System;
using System.Text;
using System.Windows.Forms;

namespace DataReduction
{
    public partial class MainForm : Form
    {
        private delegate void Updating();
        private event Updating Updated;

        public MainForm()
        {
            InitializeComponent();
            Updated = UpdateUIHaffman;
            Updated();
        }

        private void UpdateUI()
        {
            var alphabet = new Alphabet(rtbIncoming.Text);
            var result = "";

            alphabet.SortByFrequency(reverse: true);

            foreach (var ch in alphabet.Chars) result += $"{ch}\t{alphabet.GetFrequency(ch)}\t{alphabet.GetRelativeFrequency(ch):0.000000}\r\n";

            tbAlphabet.Text = result;
            lCharCount.Text = alphabet.CharCount.ToString();
            lBitCount.Text = alphabet.GetBitCount(Encoding.ASCII).ToString();
            lBitPerChar.Text = alphabet.GetBitPerChar(Encoding.ASCII).ToString("0.###");
            lEntropy.Text = alphabet.Entropy.ToString("0.###");
            lZippedCount.Text = "";
        }

        private void UpdateUIHaffman()
        {
            var alphabet = new Alphabet(rtbIncoming.Text);
            var result = "";
            var tree = new HaffmanTree(alphabet);
            var count = 0;

            alphabet.SortByFrequency(reverse: true);

            foreach (var ch in alphabet.Chars)
            {
                var charCode = tree.GetCharCode(ch);
                count += charCode.Length * alphabet.GetFrequency(ch);
                result += $"{ch}\t{alphabet.GetFrequency(ch)}\t{alphabet.GetRelativeFrequency(ch):0.000000}\t\t{charCode}\r\n";
            }

            tbAlphabet.Text = result;
            lCharCount.Text = alphabet.CharCount.ToString();
            lBitCount.Text = alphabet.GetBitCount(Encoding.ASCII).ToString();
            lBitPerChar.Text = alphabet.GetBitPerChar(Encoding.ASCII).ToString("0.###");
            lEntropy.Text = alphabet.Entropy.ToString("0.###");
            lZippedCount.Text = $"Количество бит сжатого текста: {count}";
        }

        private void rtbIncoming_TextChanged(object sender, EventArgs e)
        {
            Updated();
        }

        private void tsmiОткрыть_Click(object sender, EventArgs e)
        {
            // TODO: realize
            MessageBox.Show("максимкаскотинка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tsmiДеревоХаффмана_Click(object sender, EventArgs e)
        {
            var tree = new HaffmanTree(new Alphabet(rtbIncoming.Text));
            new HaffmanForm(tree).Show();
            Updated = UpdateUIHaffman;
            Updated();
        }

        private void tsmiLZ78_Click(object sender, EventArgs e)
        {

        }
    }
}
