using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataReduction
{
    public enum LZType { LZ78 }

    public partial class LZForm : Form
    {
        string _text = "";
        List<string> _dict = new List<string>();
        List<string> _code = new List<string>();
        int _length = 0;
        LZType _type;

        public LZForm(LZType type, string incoming)
        {
            InitializeComponent();
            _type = type;
            _text = incoming;
        }

        private void LZForm_Load(object sender, EventArgs e)
        {
            cbZippType.DataSource = Enum.GetValues(typeof(LZType));
            nudDictLength.ValueChanged += (sen, ev) => nudBufferLength.Maximum = nudDictLength.Value;
            UpdateData();
        }

        private void UpdateData()
        {
            switch (_type)
            {
                case LZType.LZ78:
                default:
                    LZ78();
                    break;
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            var max = 0;

            dgvData.Rows.Clear();
            if ((max = Math.Max(_dict.Count, _code.Count)) > 0) dgvData.Rows.Add(max);

            for (int i = 0; i < _dict.Count; i++) dgvData.Rows[i].Cells[0].Value = _dict[i];
            for (int i = 0; i < _code.Count; i++) dgvData.Rows[i].Cells[0].Value = _code[i];

            lZippedCount.Text = $"{_length}";
        }

        private void LZ78()
        {
            throw new NotImplementedException();
        }

        private void DataNeedUpdating(object sender, EventArgs e) => UpdateData();
    }
}
