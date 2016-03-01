using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DataReduction
{
    public partial class MainForm : Form
    {
        private delegate void Updating();
        private event Updating Updated;
        private Encoding _encoding;

        public MainForm()
        {
            InitializeComponent();

            _encoding = Encoding.GetEncoding("windows-1251");
            Updated = UpdateUIHaffman;
            Updated();
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
            lBitCount.Text = alphabet.GetBitCount(_encoding).ToString();
            lBitPerChar.Text = alphabet.GetBitPerChar(_encoding).ToString("0.###");
            lEntropy.Text = alphabet.Entropy.ToString("0.###");
            lZippedCount.Text = $"Количество бит сжатого текста: {count}";
            lEntropy.BorderSides = ToolStripStatusLabelBorderSides.Right;
        }

        private void rtbIncoming_TextChanged(object sender, EventArgs e) => Updated?.Invoke();

        private void tsmiОткрыть_Click(object sender, EventArgs e)
        {
            if (!ofdTextFile.ShowDialog().Equals(DialogResult.OK)) return;
            rtbIncoming.Text = File.ReadAllText(ofdTextFile.FileName);
        }

        private void tsmiДеревоХаффмана_Click(object sender, EventArgs e)
        {
            var tree = new HaffmanTree(new Alphabet(rtbIncoming.Text));
            new HaffmanForm(tree).Show();
            Updated = UpdateUIHaffman;
            Updated();
        }

        private void tsmiLZ78_Click(object sender, EventArgs e) => new LZForm(LZType.LZ78, rtbIncoming.Text).Show();

        private void tsmiLZV_Click(object sender, EventArgs e) => new LZForm(LZType.LZV, rtbIncoming.Text).Show();

        private void tsmiLZSS_Click(object sender, EventArgs e) => new LZForm(LZType.LZSS, rtbIncoming.Text).Show();
    }
}
