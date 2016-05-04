using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Goley
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bPerfect.PerformClick();
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            var initialLength = nudInitialLength.Value + 1;
            var checkerLength = nudCheckerLength.Value + 1;

            dgvInitialData.Rows.Clear();
            dgvInitialData.Columns.Clear();

            dgvAddingData.Rows.Clear();
            dgvAddingData.Columns.Clear();

            dgvErrorCheck.Rows.Clear();
            dgvErrorCheck.Columns.Clear();

            dgvPolynom.Rows.Clear();
            dgvPolynom.Columns.Clear();

            for (var i = 0; i < initialLength; i++) dgvInitialData.Columns.Add($"{i}", $"{i}");
            for (var i = 0; i < checkerLength; i++) dgvPolynom.Columns.Add($"{i}", $"{i}");

            for (var i = 0; i < initialLength + checkerLength - 1; i++)
            {
                dgvAddingData.Columns.Add($"{i}", $"{i}");
                dgvErrorCheck.Columns.Add($"{i}", $"{i}");
            }

            dgvInitialData.Rows.Add();
            dgvPolynom.Rows.Add();
            dgvAddingData.Rows.Add();
            dgvErrorCheck.Rows.Add();

            for (var i = 0; i < initialLength; i++) dgvInitialData[i, 0].Value = 0;
            for (var i = 0; i < checkerLength; i++) dgvPolynom[i, 0].Value = 0;
        }

        private Matrix GetInitialData()
        {
            var matrix = new Matrix(1, dgvInitialData.ColumnCount);

            for (int i = 0; i < dgvInitialData.ColumnCount; i++)
                matrix[0, i] = double.Parse(dgvInitialData[i, 0].Value.ToString());

            return matrix;
        }

        private List<int> GetPolynom(DataGridView dgv)
        {
            var list = new List<int>();

            for (int i = 0; i < dgv.ColumnCount; i++)
                list.Add(int.Parse(dgv[i, 0].Value.ToString()));

            return list;
        }

        private Matrix GetPolynomMatrix()
        {
            var rows = dgvInitialData.ColumnCount;
            var cols = dgvPolynom.ColumnCount;

            var matrix = new Matrix(rows, rows + cols - 1);
            var polynom = GetPolynom(dgvPolynom);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                    matrix[i, j] = 0;
                for (int j = i; j < i + cols; j++)
                    matrix[i, j] = polynom[j - i];
                for (int j = i + cols; j < rows + cols - 1; j++)
                    matrix[i, j] = 0;
            }

            return matrix;
        }

        private List<int> GetAddingData()
        {
            var matrix = GetInitialData()*GetPolynomMatrix();
            var list = new List<int>();

            for (int i = 0; i < matrix.ColumnsCount; i++)
                list.Add((int)matrix[0, i] % 2);

            return list;
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var result = GetAddingData();

            for (int i = 0; i < result.Count; i++)
            {
                dgvAddingData[i, 0].Value = result[i];
                dgvErrorCheck[i, 0].Value = result[i];
            }
        }

        private List<int> NormalizePolynom(List<int> polynom) =>
            polynom.Select(x => Math.Abs(x)%2).ToList();

        private List<int> DividePolynoms(List<int> a, List<int> b)
        {
            var temp = new int[a.Count];
            a.CopyTo(temp);

            var result = temp.ToList();

            for (int i = 0; i < result.Count - b.Count; i++)
                if (result[i] == 1)
                {
                    for (int j = i; j < i + b.Count; j++) result[j] -= b[j - i];
                    result = NormalizePolynom(result);
                }

            while (result.Count > 0 && result[0] == 0) result.RemoveAt(0);

            return result;
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            var result = DividePolynoms(GetPolynom(dgvErrorCheck), GetPolynom(dgvPolynom));

            if (result.Count > 0)
                MessageBox.Show(
                    "В полиноме есть ошибка\nОстаток: " + string.Join("", result),
                    @"Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                MessageBox.Show(
                    "В полиноме ошибок не обнаружено",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }

        private void bPerfect_Click(object sender, EventArgs e)
        {
            nudInitialLength.Value = 11;
            nudCheckerLength.Value = 11;

            var polynom = new[] {1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1};

            for (var i = 0; i < polynom.Length; i++) dgvPolynom[i, 0].Value = polynom[i];
        }
    }
}
