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
            lBitCount.Text = alphabet.GetBitCount(Encoding.UTF8).ToString();
            lBitPerChar.Text = alphabet.GetBitPerChar(Encoding.UTF8).ToString("0.###");
            lEntropy.Text = alphabet.Entropy.ToString("0.###");
        }

        private void rtbIncoming_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}
