using System;
using System.Linq;
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
            var len = (int) nudInfWordLength.Value;

            rtbOriginalBits.Text = string.Join
                (
                    _splitter,
                    rtbIncoming.Text
                        .GetBitsString()
                        .Split(len)
                );
            rtbWithAdditionalBits.Text = string.Join
                (
                    _splitter,
                    rtbIncoming.Text
                        .GetHammingCode((int) nudInfWordLength.Value)
                        .Split(len + HammingCode.GetKeysCount(len))
                );
        }

        private void rtbIncoming_TextChanged(object sender, EventArgs e) => UpdateUI();

        private void nudInfWordLength_ValueChanged(object sender, EventArgs e) => UpdateUI();

        private void cbNewString_CheckStateChanged(object sender, EventArgs e)
        {
            _splitter = cbNewString.CheckState.Equals(CheckState.Checked) ? "\r\n" : "";
            UpdateUI();
        }

        private void bShowExample_Click(object sender, EventArgs e)
        {
            new HammingExampleForm
                (
                    rtbIncoming.Text
                        .GetBitsString()
                        .Split((int) nudInfWordLength.Value)
                        .FirstOrDefault()
                ).Show();
        }
    }
}
