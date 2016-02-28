using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataReduction
{
    public enum LZType { LZ78 }

    public partial class LZForm : Form
    {
        readonly string _text;
        List<string> _dict = new List<string>();
        readonly List<string> _code = new List<string>();
        int _length;
        readonly LZType _type;

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
                default:
                    LZ78();
                    break;
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            int max;

            dgvData.Rows.Clear();
            if ((max = Math.Max(_dict.Count, _code.Count)) > 0) dgvData.Rows.Add(max);

            for (int i = 0; i < _dict.Count; i++) dgvData.Rows[i].Cells[0].Value = _dict[i];
            for (int i = 0; i < _code.Count; i++) dgvData.Rows[i].Cells[1].Value = _code[i];

            lZippedCount.Text = $"{_length}";
        }

        private void LZ78()
        {
            nudBufferLength.Enabled = false;
            lBuffer.Enabled = false;
            cbZippType.SelectedItem = LZType.LZ78;

            var deletedDict = new List<string>();
            var dictLength = (int)nudDictLength.Value;
            var dictPosSize = (int)Math.Ceiling(Math.Log(dictLength, 2));
            var text = _text;

            _dict.Clear();
            deletedDict.Clear();
            _code.Clear();
            _dict.Add("");
            _length = 0;

            while (text.Length > 0)
            {
                var el = "";
                var sortedDict = _dict.Select(x => x).ToList();
                sortedDict.Sort((x, y) => y.Length.CompareTo(x.Length));

                foreach (var item in sortedDict)
                {
                    if (text.StartsWith(item))
                    {
                        el = item;
                        break;
                    }
                }

                var len = el.Length;

                _code.Add($"{_dict.IndexOf(el)}'{(text.Length == len ? "" : text.Substring(len, 1))}'");
                if (len < text.Length) _dict.Add(text.Substring(0, len + 1));
                _length += dictPosSize + (text.Length == len ? 0 : 8 * Encoding.ASCII.GetByteCount(text.Substring(len, 1)));

                if (_dict.Count > dictLength)
                {
                    deletedDict.Add(_dict[1]);
                    _dict.RemoveAt(1);
                }

                text = text.Length == len ? "" : text.Substring(len + 1);
            }

            _dict = _dict.Select(x => $"'{x}'").ToList();
            _dict.InsertRange(1, deletedDict.Select(x => $"✘ '{x}'"));
        }

        private void DataNeedUpdating(object sender, EventArgs e) => UpdateData();
    }
}
