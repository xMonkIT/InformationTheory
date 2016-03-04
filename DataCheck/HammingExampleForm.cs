using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataCheck
{
    public partial class HammingExampleForm : Form
    {
        private readonly string _infWord;

        public HammingExampleForm(string infWord)
        {
            InitializeComponent();
            _infWord = infWord ?? "te".GetBitsString();
            UpdateUI();
        }

        private void UpdateUI()
        {
            SetInitialData();
            SetAddingData();
            UpdateErrorCheck();
        }

        private void SetInitialData()
        {
            dgvInitialData.Rows.Clear();
            dgvInitialData.Columns.Clear();

            for (int i = 0; i < _infWord.Length; i++) dgvInitialData.Columns.Add("", "");

            dgvInitialData.Rows.Add();

            for (int i = 0; i < _infWord.Length; i++) dgvInitialData.Rows[0].Cells[i].Value = _infWord[i];
        }

        private void SetAddingData()
        {
            dgvAddingData.Rows.Clear();
            dgvAddingData.Columns.Clear();

            var code = _infWord.InsertControlBits();

            for (int i = 0; i < code.Length; i++) dgvAddingData.Columns.Add("", "");

            var index = dgvAddingData.Rows.Add();

            for (int i = 0; i < code.Length; i++) dgvAddingData.Rows[index].Cells[i].Value = code[i];

            for (int i = 0; i < HammingCode.GetKeysCount(_infWord.Length); i++)
            {
                var k = (1 << i) - 1;

                index = dgvAddingData.Rows.Add();

                for (int j = 0; j < code.Length; j++)
                    if (j >= k && (j - k)/(k + 1)%2 == 0) dgvAddingData.Rows[index].Cells[j].Value = '*';
            }

            code = code.CalcControlBits();
            index = dgvAddingData.Rows.Add();

            for (int i = 0; i < code.Length; i++) dgvAddingData.Rows[index].Cells[i].Value = code[i];
        }

        private void UpdateErrorCheck()
        {
            dgvErrorCheck.Rows.Clear();
            dgvErrorCheck.Columns.Clear();

            var errStyle = new DataGridViewCellStyle
            {
                Font = new Font(SystemFonts.DefaultFont, FontStyle.Bold),
                ForeColor = Color.WhiteSmoke,
                BackColor = Color.Red
            };

            var keyStyle = new DataGridViewCellStyle
            {
                Font = new Font(SystemFonts.DefaultFont, FontStyle.Bold),
                ForeColor = Color.WhiteSmoke,
                BackColor = Color.DarkRed
            };

            var code = _infWord.InsertControlBits().CalcControlBits();

            for (int i = 0; i < code.Length; i++) dgvErrorCheck.Columns.Add("", $"{i+1}");

            var index = dgvErrorCheck.Rows.Add();

            for (int i = 0; i < code.Length; i++) dgvErrorCheck.Rows[index].Cells[i].Value = code[i];

            var codeWithError = new StringBuilder(code);
            var keys = new List<int>();
            var rand = new Random();
            int errIndex;

            for (int i = 0; i < HammingCode.GetKeysCount(_infWord.Length); i++)
                keys.Add((1 << i) - 1);

            do errIndex = rand.Next(codeWithError.Length); while (keys.Contains(errIndex));

            codeWithError[errIndex] = codeWithError[errIndex].Equals('0') ? '1' : '0';

            index = dgvErrorCheck.Rows.Add();

            for (int i = 0; i < codeWithError.Length; i++) dgvErrorCheck.Rows[index].Cells[i].Value = codeWithError[i];

            dgvErrorCheck.Rows[index].Cells[errIndex].Style = errStyle;
            
            codeWithError = new StringBuilder(codeWithError.ToString().CalcControlBits());

            index = dgvErrorCheck.Rows.Add();

            for (int i = 0; i < codeWithError.Length; i++) dgvErrorCheck.Rows[index].Cells[i].Value = codeWithError[i];

            index = keys
                .Where(key => !code[key].Equals(codeWithError[key]))
                .Sum(key =>
                {
                    dgvErrorCheck.Rows[0].Cells[key].Style = keyStyle;
                    dgvErrorCheck.Rows[2].Cells[key].Style = keyStyle;
                    return key + 1;
                });

            lError.Text = $"Ошибка в {index} бите";
            dgvErrorCheck.ClearSelection();
        }

        private void dgvErrorCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) UpdateErrorCheck();
        }

        private void HammingExampleForm_Load(object sender, EventArgs e)
        {
            dgvInitialData.ClearSelection();
            dgvAddingData.ClearSelection();
            dgvErrorCheck.ClearSelection();
        }
    }
}
