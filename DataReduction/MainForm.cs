using System;
using System.Text;
using System.Windows.Forms;

namespace DataReduction
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            var alphabet = new Alphabet(rtbIncoming.Text);
            var result = "";

            alphabet.SortByFrequency(reverse:true);

            foreach (var ch in alphabet.Chars) result += $"{ch} - {alphabet.GetFrequency(ch)} - {alphabet.GetRelativeFrequency(ch):0.########}\r\n";

            tbAlphabet.Text = result;
            lCharCount.Text = alphabet.CharCount.ToString();
            lBitCount.Text = alphabet.GetBitCount(Encoding.ASCII).ToString();
            lBitPerChar.Text = alphabet.GetBitPerChar(Encoding.ASCII).ToString("0.###");
            lEntropy.Text = alphabet.Entropy.ToString("0.###");
        }

        private void rtbIncoming_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void tsmiОткрыть_Click(object sender, EventArgs e)
        {
            MessageBox.Show("максимкаскотинка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tsmiДеревоХаффмана_Click(object sender, EventArgs e)
        {
            new HaffmanForm(new HaffmanTree(new Alphabet(rtbIncoming.Text))).Show();
        }
    }
}
