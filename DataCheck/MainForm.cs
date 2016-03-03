using System;
using System.Windows.Forms;

namespace DataCheck
{
    public partial class MainForm : Form
    {
        private string _splitter = "\r\n";

        public MainForm()
        {
            InitializeComponent();
            UpdateUI = UpdateUIHamming;
        }

        private Action UpdateUI { get; set; }

        private void UpdateUIHamming()
        {
            rtbOriginalBits.Text = string.Join(_splitter,
                rtbIncoming.Text.GetBitsString().Split((int) nudInfWordLength.Value));
            rtbWithAdditionalBits.Text = string.Join(_splitter,
                rtbIncoming.Text.GetHammingCode((int) nudInfWordLength.Value)
                    .Split((int) nudInfWordLength.Value + HammingCode.GetKeysCount((int) nudInfWordLength.Value)));
        }

        private void rtbIncoming_TextChanged(object sender, System.EventArgs e) => UpdateUI();

        private void nudInfWordLength_ValueChanged(object sender, EventArgs e) => UpdateUI();

        private void cbNewString_CheckStateChanged(object sender, EventArgs e)
        {
            _splitter = cbNewString.CheckState.Equals(CheckState.Checked) ? "\r\n" : "";
            UpdateUI();
        }
    }
}
