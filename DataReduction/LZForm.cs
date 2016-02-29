using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataReduction
{
    public enum LZType { LZ78, LZV, LZSS }

    public partial class LZForm : Form
    {
        readonly string _text;
        List<string> _dict = new List<string>();
        readonly List<string> _code = new List<string>();
        int _length;
        LZType _type;
        private readonly Encoding _enc;

        public LZForm(LZType type, string incoming, Encoding enc)
        {
            InitializeComponent();

            _type = type;
            _text = incoming;
            _enc = enc;
        }

        public LZForm(LZType type, string incoming) : this(type, incoming, Encoding.GetEncoding("windows-1251")) { }

        private void LZForm_Load(object sender, EventArgs e)
        {
            cbZippType.DataSource = Enum.GetValues(typeof(LZType));
            cbZippType.SelectedItem = _type;

            switch (_type)
            {
                case LZType.LZ78:
                    nudDictLength.Value = 256;
                    break;
                case LZType.LZV:
                    nudDictLength.Value = 512;
                    break;
                case LZType.LZSS:
                    nudDictLength.Value = 128;
                    nudBufferLength.Value = 64;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            cbZippType.SelectedIndexChanged += cbZippType_SelectedIndexChanged;
            nudDictLength.ValueChanged += nudDictLength_ValueChanged;
            nudBufferLength.ValueChanged += nudBufferLength_ValueChanged;

            UpdateData();
        }

        private void UpdateData()
        {
            switch (_type)
            {
                case LZType.LZ78:
                    LZ78();
                    break;
                case LZType.LZV:
                    LZV();
                    break;
                case LZType.LZSS:
                    LZSS();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
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
                var sortedDict = _dict.Select(x => x).ToList();
                sortedDict.Sort((x, y) => y.Length.CompareTo(x.Length));

                var el = sortedDict.FirstOrDefault(x => text.StartsWith(x)) ?? "";
                var len = el.Length;

                _code.Add($"{_dict.IndexOf(el)}'{(text.Length == len ? "" : text.Substring(len, 1))}'");
                if (len < text.Length) _dict.Add(text.Substring(0, len + 1));
                _length += dictPosSize + (text.Length == len ? 0 : 8 * _enc.GetByteCount(text.Substring(len, 1)));

                if (_dict.Count > dictLength)
                {
                    deletedDict.Add(_dict[1]);
                    _dict.RemoveAt(1);
                }

                text = text.Substring(len + 1);
            }

            _dict = _dict.Select(x => $"'{x}'").ToList();
            _dict.InsertRange(1, deletedDict.Select(x => $"✘ '{x}'"));
        }

        private void LZV()
        {
            nudBufferLength.Enabled = false;
            lBuffer.Enabled = false;

            var deletedDict = new List<string>();
            var dictLength = (int)nudDictLength.Value;
            var dictPosSize = (int)Math.Ceiling(Math.Log(dictLength, 2));
            var text = _text;

            _dict.Clear();
            deletedDict.Clear();
            _code.Clear();

            for (int i = 0; i < 256; i++) _dict.Add(_enc.GetString(new [] { (byte)i }));

            _length = 0;

            var w = "";

            if (text.Length > 0)
            {
                w = text.Substring(0, 1);
                text = text.Substring(1);
            }

            while (text.Length > 0)
            {
                var k = text.Substring(0, 1);

                if (_dict.Contains($"{w}{k}")) w += k;
                else
                {
                    _code.Add($"{(w.Length == 1 ? _enc.GetBytes(w)[0] : _dict.IndexOf(w))} (\"{w}\")");
                    _dict.Add($"{w}{k}");
                    w = k;
                }

                text = text.Substring(1);

                if (_dict.Count <= dictLength) continue;
                deletedDict.Add(_dict[256]);
                _dict.RemoveAt(256);
            }

            if (w.Length > 0) _code.Add($"{_dict.IndexOf(w)} (\"{w}\")");

            _length = dictPosSize*_code.Count;

            _dict = _dict.Select(x => $"'{x}'").ToList();
            _dict.InsertRange(256, deletedDict.Select(x => $"✘ '{x}'"));
            _dict.RemoveRange(0, 255);
            _dict[0] = "ASCII";
        }

        private void LZSS()
        {
            nudBufferLength.Enabled = true;
            lBuffer.Enabled = true;
            
            var dictLength = (int)nudDictLength.Value;
            var buffLength = (int) nudBufferLength.Value;
            var dictPosSize = (int)Math.Ceiling(Math.Log(dictLength, 2));
            var buffSize = (int)Math.Ceiling(Math.Log(buffLength, 2));
            var text = _text;
            var dict = "";
            var buff = text.Substring(0, text.Length > buffLength ? buffLength : text.Length);

            _dict.Clear();
            _code.Clear();
            _length = 0;

            while (buff.Length > 0)
            {
                var response = "";

                while (response.Length != buff.Length &&
                       dict.Contains($"{response}{buff.Substring(response.Length, 1)}"))
                    response += buff[response.Length];

                if (response.Length == 0)
                {
                    _code.Add($"0'{buff[0]}'");
                    _length += 1 + _enc.GetByteCount(buff.Substring(0, 1)) * 8;
                }
                else
                {
                    var index = dict.IndexOf(response, StringComparison.Ordinal);
                    index += dictLength - dict.Length;
                    _code.Add($"1<{index},{response.Length}>");
                    _length += 1 + dictPosSize + buffSize;
                    dict += text.Substring(0, response.Length - 1);
                    if (dict.Length > dictLength) dict = dict.Substring(dict.Length - dictLength - 1);
                    text = text.Substring(response.Length - 1);
                }
                
                _dict.Add($"'{dict}' - '{buff}'");

                dict += text[0];
                if (dict.Length > dictLength) dict = dict.Substring(1);

                buff = text.Substring(1, buffLength < text.Length - 1 ? buffLength : text.Length - 1);

                text = text.Substring(1);
            }
        }

        private void cbZippType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _type = (LZType)cbZippType.SelectedItem;
            nudDictLength.Minimum = _type == LZType.LZV ? 257 : 2;
            UpdateData();
        }

        private void nudDictLength_ValueChanged(object sender, EventArgs e)
        {
            nudBufferLength.Maximum = nudDictLength.Value;
            UpdateData();
        }

        private void nudBufferLength_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
