using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LZ78Archiver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static List<Tuple<int, string>> LZ78(string text, int dictLength)
        {
            var code = new List<Tuple<int, string>>();
            var dict = new List<string> {""};
            
            while (text.Length > 0)
            {
                var sortedDict = dict.Select(x => x).ToList();
                sortedDict.Sort((x, y) => y.Length.CompareTo(x.Length));

                var el = sortedDict.FirstOrDefault(x => text.StartsWith(x)) ?? "";
                var len = el.Length;

                code.Add(new Tuple<int, string>(dict.IndexOf(el), text.Length == len ? "" : text.Substring(len, 1)));
                if (len < text.Length) dict.Add(text.Substring(0, len + 1));

                if (dict.Count > dictLength) dict.RemoveAt(1);

                text = text.Substring((text.Length == len ? len - 1 : len) + 1);
            }

            return code;
        }

        private static string LZ78Back(IEnumerable<Tuple<int, string>> code, int dictLength)
        {
            var text = "";
            var dict = new List<string> { "" };

            foreach (var tuple in code)
            {
                var str = dict[tuple.Item1] + tuple.Item2;

                text += str;
                dict.Add(str);

                if (dict.Count > dictLength) dict.RemoveAt(1);
            }

            return text;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!sfdSaveArchive.ShowDialog().Equals(DialogResult.OK)) return;

            var filename = sfdSaveArchive.FileName.EndsWith(".lz78")
                ? sfdSaveArchive.FileName
                : sfdSaveArchive.FileName + ".lz78";

            var fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            var bw = new BinaryWriter(fs);

            bw.Write(Archive(LZ78(rtbData.Text, (int) nudDictLength.Value)));

            bw.Close();
        }

        private byte[] Archive(IReadOnlyCollection<Tuple<int, string>> code)
        {
            var dictLength = (short) nudDictLength.Value;
            var dictPosSize = (int) Math.Ceiling(Math.Log(dictLength, 2));
            var result = new byte[(int) Math.Ceiling((dictPosSize + 8)*code.Count/8.0) + 2];
            var temp = new List<byte>();
            var remainLength = (8 - (dictPosSize + 8)*code.Count%8)%8;
            var enc = Encoding.GetEncoding("windows-1251");

            for (int i = 0; i < 13; i++)
                temp.Add((byte)((dictLength >> (12 - i)) & 1));
            for (int i = 0; i < 3; i++)
                temp.Add((byte)((remainLength >> (2 - i)) & 1));

            foreach (var el in code)
            {
                for (int i = 0; i < dictPosSize; i++)
                    temp.Add((byte)((el.Item1 >> (dictPosSize - 1 - i)) & 1));

                if (el.Item2 == "") break;

                var chByte = enc.GetBytes(el.Item2)[0];

                for (int i = 0; i < 8; i++)
                    temp.Add((byte)((chByte >> (7 - i)) & 1));
            }

            while (temp.Count % 8 != 0) temp.Add(0);

            for (int i = 0; i < temp.Count/8; i++)
                result[i] = (byte) temp
                    .GetRange(8*i, 8)
                    .Select((x, ind) => x << (7 - ind))
                    .Sum();

            return result;
        }

        private void tsmiОткрыть_Click(object sender, EventArgs e)
        {
            if (!ofdOpenTextOrArchive.ShowDialog().Equals(DialogResult.OK)) return;

            var filename = ofdOpenTextOrArchive.FileName;

            if (filename.EndsWith(".lz78"))
            {
                using (var br = new BinaryReader(new FileStream(filename, FileMode.Open, FileAccess.Read)))
                {
                    var byteCount = new FileInfo(filename).Length;
                    var bytes = br.ReadBytes((int) byteCount);

                    rtbData.Text = Unarchive(bytes);
                }
            }
            else using (var f = File.OpenText(filename)) rtbData.Text = f.ReadToEnd();
        }

        private string Unarchive(byte[] code)
        {
            var serviceInfo = (short) ((code[0] << 8) + code[1]);
            var remainCount = serviceInfo & 7;
            var dictLength = serviceInfo >> 3;
            var bits = new List<byte>();
            var enc = Encoding.GetEncoding("windows-1251");

            for (int i = 2; i < code.Length; i++)
                for (int j = 0; j < 8; j++)
                    bits.Add((byte)((code[i] >> (7 - j)) & 1));

            bits = bits.Take(bits.Count - remainCount).ToList();

            var len = (int)Math.Ceiling(Math.Log(dictLength, 2)) + 8;
            var result = new List<Tuple<int, string>>();

            for (int i = 0; i < bits.Count/len; i++)
            {
                var tuple = bits
                    .GetRange(len * i, len)
                    .Select((x, ind) => x << (len - 1 - ind))
                    .Sum();

                result.Add(new Tuple<int, string>(tuple >> 8, enc.GetString(new [] {(byte)tuple})));
            }

            return LZ78Back(result, dictLength);
        }
    }
}
