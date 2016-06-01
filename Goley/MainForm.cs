using System;
using System.Collections.Generic;
using System.Drawing;
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
            FillRandom(dgvInitialData);
            FillResultsDgv();
        }

        private void FillRandom(DataGridView dgv)
        {
            var rand = new Random();

            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv[i, 0].Value = rand.Next() % 2;

            if (dgv.ColumnCount > 0) dgv[0, 0].Value = 1;
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

            dgvResult.Rows.Clear();
            dgvResult.Columns.Clear();

            for (var i = 0; i < initialLength; i++) dgvInitialData.Columns.Add($"{i}", $"{i}");
            for (var i = 0; i < checkerLength; i++) dgvPolynom.Columns.Add($"{i}", $"{i}");

            for (var i = 0; i < initialLength + checkerLength - 1; i++)
            {
                dgvAddingData.Columns.Add($"{i}", $"{i}");
                dgvErrorCheck.Columns.Add($"{i}", $"{i}");
                dgvResult.Columns.Add($"{i}", $"{i}");
            }

            dgvInitialData.Rows.Add();
            dgvPolynom.Rows.Add();
            dgvAddingData.Rows.Add();
            dgvErrorCheck.Rows.Add();
            dgvResult.Rows.Add();

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
            var cell = (sender as DataGridView)?[e.ColumnIndex, e.RowIndex];

            if (cell == null) throw new ArgumentException("sender must be dataGridView");

            cell.Value = Math.Abs(int.Parse(cell.Value.ToString()))%2;

            FillResultsDgv();
        }

        private void FillResultsDgv()
        {
            var result = GetAddingData();

            for (int i = 0; i < result.Count; i++)
            {
                dgvAddingData[i, 0].Value = result[i];
                dgvErrorCheck[i, 0].Value = result[i];
            }
        }

        private static List<int> NormalizePolynom(IEnumerable<int> polynom) =>
            polynom.Select(x => Math.Abs(x)%2).ToList();

        private List<int> DividePolynoms(List<int> a, List<int> b)
        {
            var temp = new int[a.Count];
            a.CopyTo(temp);

            var result = temp.ToList();

            for (int i = 0; i <= result.Count - b.Count; i++)
            {
                var k = result[i];
                for (int j = i; j < i + b.Count; j++) result[j] -= k*b[j - i];
                result = NormalizePolynom(result);
            }

            return result;
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            if (nudCheckerLength.Value == 11 && nudInitialLength.Value == 11)
            {
                CheckData();
                return;
            } 

            var result = DividePolynoms(GetPolynom(dgvErrorCheck), GetPolynom(dgvPolynom));

            if (result.Count(x => x == 1) > 0)
                MessageBox.Show(
                    $"В полиноме есть ошибка\nОстаток: " + string.Join("", result),
                    $"Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                MessageBox.Show(
                    $"В полиноме ошибок не обнаружено",
                    $"Info",
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

        private void dgv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.F5) return;
            FillRandom(sender as DataGridView);
            FillResultsDgv();
        }

        private int GetWeight(IEnumerable<int> polynom) => polynom.Count(x => x == 1);

        private void FillDgv(DataGridView dgv, IList<int> polynom)
        {
            dgv.Rows.Clear();
            dgv.Rows.Add();

            for (var i = 0; i < polynom.Count; i++) dgv[i, 0].Value = polynom[i];
        }

        private void MarkErrors(IList<int> errors)
        {
            var errorStyle = new DataGridViewCellStyle {BackColor = Color.Red};
            var defaultStyle = dgvInitialData[0, 0].Style;

            for (int i = 0; i < errors.Count; i++)
                dgvErrorCheck[i, 0].Style = errors[i] == 1 ? errorStyle : defaultStyle;
        }

        private IEnumerable<int> XorPolynoms(IEnumerable<int> first, IEnumerable<int> second) =>
            first.Zip(second, (x, y) => x ^ y);

        private IEnumerable<int> Shift(IEnumerable<int> polynom, bool reverse = false)
        {
            var arr = polynom as int[] ?? polynom.ToArray();
            var count = reverse ? 1 : arr.Length - 1;

            return arr.Skip(count).Concat(arr.Take(count));
        }

        private void CheckData()
        {
            var initialPolynom = GetPolynom(dgvErrorCheck);
            var polynom = GetPolynom(dgvPolynom);
            var syndrome = DividePolynoms(initialPolynom, polynom);

            if (GetWeight(syndrome) == 0)
            {
                FillDgv(dgvResult, initialPolynom);
                return;
            }
            if (GetWeight(syndrome) <= 3)
            {
                MarkErrors(syndrome);
                FillDgv(dgvResult, XorPolynoms(initialPolynom, syndrome).ToList());
                return;
            }

            var shiftCount = 0;

            var initial17 = new List<int> {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            var initial18 = new List<int> {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            var syndrome17 = DividePolynoms(initial17, polynom);
            var syndrome18 = DividePolynoms(initial18, polynom);

            while (shiftCount < initialPolynom.Count)
            {
                var temp17 = XorPolynoms(syndrome17, syndrome).ToList();
                var temp18 = XorPolynoms(syndrome18, syndrome).ToList();

                var errors = GetWeight(temp17) < 3
                    ? temp17.Select((x, i) => i == 6 ? 1 : x).ToList()
                    : GetWeight(temp18) < 3
                        ? temp18.Select((x, i) => i == 5 ? 1 : x).ToList()
                        : null;

                if (errors != null)
                {
                    for (int i = 0; i < shiftCount; i++)
                        errors = Shift(errors, true).ToList();
                    for (int i = 0; i < shiftCount; i++)
                        initialPolynom = Shift(initialPolynom, true).ToList();
                    MarkErrors(errors);
                    FillDgv(dgvResult, XorPolynoms(initialPolynom, errors).ToList());
                    return;
                }

                initialPolynom = Shift(initialPolynom).ToList();
                syndrome = DividePolynoms(initialPolynom, polynom);
                shiftCount++;
            }

            MessageBox.Show(
                @"В полиноме больше 3 ошибок",
                @"Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = (sender as DataGridView)?[e.ColumnIndex, e.RowIndex];
            if (cell != null) cell.Value = 1 ^ (int)cell.Value;
        }
    }
}
