using System;
using System.Drawing;
using System.Windows.Forms;

namespace Goley
{
    class Matrix
    {
        const double Tolerance = 0.00001;

        private readonly double[,] _matrix;

        public double this[int i, int j]
        {
            get { return _matrix[i, j]; }
            set { _matrix[i, j] = value; }
        }

        /// <summary>
        /// Возвращает количество строк матрицы
        /// </summary>
        public int RowsCount => _matrix.GetLength(0);

        /// <summary>
        /// Возвращает количество столбцов матрицы
        /// </summary>
        public int ColumnsCount => _matrix.GetLength(1);

        #region Constructors

        /// <summary>
        /// Создает новую матрицу размером 4х4
        /// </summary>
        public Matrix() : this(4, 4) { }

        /// <summary>
        /// Создает новую матрицу
        /// </summary>
        /// <param name="rows">Количество строк</param>
        /// <param name="columns">Количество столбцов</param>
        public Matrix(int rows, int columns)
        {
            _matrix = new double[rows, columns];
        }

        #endregion

        public void CopyTo(Matrix matrix)
        {
            for (var i = 0; i < RowsCount; i++)
            {
                for (var j = 0; j < ColumnsCount; j++)
                {
                    matrix[i, j] = _matrix[i, j];
                }
            }
        }

        /// <summary>
        /// Заполняет матрицу случайными величинами
        /// </summary>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значени</param>
        /// <param name="rand">Генератор псевдослучайных чисел при создании нескольких матриц одновременно</param>
        public void FillRandom(int min = -100, int max = 100, Random rand = null)
        {
            rand = rand ?? new Random();
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    do
                    {
                        _matrix[i, j] = rand.Next(min, max);
                    } while (Math.Abs(_matrix[i, j]) < Tolerance);
                }
            }
        }

        /// <summary>
        /// Добавляет матрицу в элемент DataGridView
        /// </summary>
        /// <param name="dgv">Элемент DataGridView</param>
        public void AddMatrixToDgv(DataGridView dgv)
        {
            int rows = _matrix.GetLength(0);
            int columns = _matrix.GetLength(1);

            // Добавление столбцов в DataGridView при нехватке
            for (int i = dgv.ColumnCount; i < columns; i++)
            {
                dgv.Columns.Add(i.ToString(), i.ToString());
            }

            for (int i = 0; i < rows; i++)
            {
                var index = dgv.Rows.Add();
                for (int j = 0; j < columns; j++)
                {
                    dgv.Rows[index].Cells[j].Value = $"{_matrix[i, j]:0.###}";
                }
            }
        }

        /// <summary>
        /// Умножает матрицу A на матрицу B
        /// </summary>
        /// <param name="a">Матрица A</param>
        /// <param name="b">Матрица B</param>
        /// <returns>Результат перемножения</returns>
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.ColumnsCount != b.RowsCount)
                throw new ArithmeticException("Матрицы должны быть размерностью m*n и n*k соответственно");
            var c = new Matrix(a.RowsCount, b.ColumnsCount);
            for (var i = 0; i < a.RowsCount; i++)
            {
                for (var j = 0; j < b.ColumnsCount; j++)
                {
                    for (var k = 0; k < b.RowsCount; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return c;
        }

        internal static Matrix ForwardMove(Matrix defaultMatrix)
        {
            var matrix = new Matrix(defaultMatrix.RowsCount, defaultMatrix.ColumnsCount);
            defaultMatrix.CopyTo(matrix);
            for (var i = 0; i < matrix.RowsCount - 1; i++)
            {
                if (Math.Abs(matrix[i, i]) < Tolerance)
                    throw new Exception("Для решения данной системы необходимо допилить сортировку строк");
                for (var j = i + 1; j < matrix.RowsCount; j++)
                {
                    var koef = -matrix[j, i] / matrix[i, i];
                    for (var k = i; k < matrix.ColumnsCount; k++)
                    {
                        matrix[j, k] += koef * matrix[i, k];
                    }
                }
            }
            return matrix;
        }

        internal static Matrix ReverseMove(Matrix defaultMatrix)
        {
            var matrix = new Matrix(defaultMatrix.RowsCount, defaultMatrix.ColumnsCount);
            defaultMatrix.CopyTo(matrix);
            double koef;
            for (var i = matrix.RowsCount - 1; i > 0; i--)
            {
                if (Math.Abs(matrix[i, i]) < Tolerance)
                    throw new Exception("Все не то и все не так, когда вместо 1 у тебя 0");
                koef = matrix[i, i];
                for (var j = 0; j < matrix.ColumnsCount; j++) matrix[i, j] /= koef;
                for (var j = 0; j < i; j++)
                {
                    koef = -matrix[j, i];
                    for (var k = 0; k < matrix.ColumnsCount; k++)
                    {
                        matrix[j, k] += koef * matrix[i, k];
                    }
                }
            }
            koef = matrix[0, 0];
            for (var j = 0; j < matrix.ColumnsCount; j++) matrix[0, j] /= koef;
            return matrix;
        }

        public Matrix Gauss()
        {
            // TODO: realize
            return null;
        }

        /// <summary>
        /// Нахождение макимального значения матрицы
        /// </summary>
        /// <returns>Возвращает координаты максимума</returns>
        public Point GetMaxPosition(int startRowIndex = 0, int startColumnIndex = 0)
        {
            var coords = new Point(startRowIndex, startColumnIndex);
            var max = this[startRowIndex, startColumnIndex];
            for (var i = startRowIndex; i < RowsCount; i++)
            {
                for (var j = startColumnIndex; j < ColumnsCount; j++)
                {
                    if ((this[i, j] <= max)) continue;
                    max = this[i, j];
                    coords.X = i;
                    coords.Y = j;
                }
            }
            return coords;
        }

        /// <summary>
        /// Меняет местами строки матрицы
        /// </summary>
        /// <param name="firstRowIndex">Индекс первой строки</param>
        /// <param name="secondRowIndex">Индекс второй строки</param>
        public void SwapRows(int firstRowIndex, int secondRowIndex)
        {
            for (var j = 0; j < ColumnsCount; j++)
            {
                var temp = this[firstRowIndex, j];
                this[firstRowIndex, j] = this[secondRowIndex, j];
                this[secondRowIndex, j] = temp;
            }
        }

        /// <summary>
        /// Меняет местами столбцы матрицы
        /// </summary>
        /// <param name="firstColumnIndex">Индекс первого столбца</param>
        /// <param name="secondColumnIndex">Индекс второго столбца</param>
        public void SwapColumns(int firstColumnIndex, int secondColumnIndex)
        {
            for (var i = 0; i < RowsCount; i++)
            {
                var temp = this[i, firstColumnIndex];
                this[i, firstColumnIndex] = this[i, secondColumnIndex];
                this[i, secondColumnIndex] = temp;
            }
        }
    }
}
