using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private int i = 0;
        private int n, m;
        private int[,] ptr = new int[,] { };

        public Form1()
        {
            InitializeComponent();

            resetBtn.Enabled = false;
            resetMatrixBtn.Enabled = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            resetBtn.Enabled = true;
            infoLabel.Text = "";
            resetBtn_Click(sender, e);

            int start = Convert.ToInt32(startNumericUpDown.Value);
            int end = Convert.ToInt32(endNumericUpDown.Value);
            int step = Convert.ToInt32(stepNumericUpDown.Value);
            int min = Convert.ToInt32(minNumericUpDown.Value);
            int max = Convert.ToInt32(maxNumericUpDown.Value);
            int count, current = 0;
            count = 0;

            if (max < min)
            {
                infoLabel.Text = "Макс значение не м.б. меньше мин значения!";
                return;
            }

            count = (end - start) / step + 1;

            for (int n = start; n <= end; n += step)
            {
                int[] vptr = new int[n];
                Random random = new Random();
                for (int j = 0; j < n; j++)
                {
                    vptr[j] = random.Next(min, max);

                }

                if (inTableCheckBox.Checked)
                {
                    arraysDataGridView.ColumnCount = n + 1;
                    arraysDataGridView.Rows.Add();
                    arraysDataGridView.Rows[i].Cells[0].Value = "Исходный массив";
                    for (int j = 0; j < n; j++)
                    {
                        arraysDataGridView.Rows[i].Cells[j + 1].Value = vptr[j];
                    }

                    this.i++;
                }

                sort(vptr, n);
                current += 1;
                progressBar.Value = 100 * current / count;
            }
        }

        private void sort(int[] p, int n)
        {
            int k = 0, sr = 0, obm = 0, m = 0;
            for (int j = 0; j < n; j++)
            {
                if (p[j] == 0) k++;
                else p[j - k] = p[j];
            }
            n -= k;
            sr += n;
            if (n == 0)
            {
                infoLabel.Text = "В массиве одни нули"; return;
            }
            for (m = 0; m < n - 1; m++)
                for (int j = m + 1; j < n; j++)
                {
                    if (p[m] > 0 && p[j] > 0 && p[m] < p[j])
                    {
                        swap(ref p[m], ref p[j]); obm++;
                    }
                    if (p[m] < 0 && p[j] < 0 && p[m] > p[j])
                    {
                        swap(ref p[m], ref p[j]); obm++;
                    }
                    sr += 6;
                }
            if (inTableCheckBox.Checked)
            {
                arraysDataGridView.AutoResizeColumns();
                arraysDataGridView.Rows.Add();
                arraysDataGridView.Rows[i].Cells[0].Value = "Получен массив";
                for (int j = 0; j < n; j++)
                { arraysDataGridView.Rows[i].Cells[j + 1].Value = p[j]; }
                i++;
            }


            if (Convert.ToInt32(startNumericUpDown.Value) ==
            Convert.ToInt32(endNumericUpDown.Value))
            {
                infoLabel.Text = "Количество сравнений=" +
            Convert.ToString(sr) + " Количество обменов=" + Convert.ToString(obm);
            }
            if (inChartsCheckBox.Checked)
            {
                chart1.Series[0].Points.AddXY(n, sr);
                chart2.Series[0].Points.AddXY(n, obm);
            }
        }

        void swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            arraysDataGridView.Rows.Clear();
            arraysDataGridView.Columns.Clear();
            defaultMatrixDataGridView.Rows.Clear();
            defaultMatrixDataGridView.Columns.Clear();
            this.i = 0;
            resetBtn.Enabled = false;
        }

        private void resetMatrixBtn_Click(object sender, EventArgs e)
        {
            defaultMatrixDataGridView.Rows.Clear();
            defaultMatrixDataGridView.Columns.Clear();
            resultMatrixDataGridView.Rows.Clear();
            resultMatrixDataGridView.Columns.Clear();
            resultMatrixDataGridView.Enabled = true;
            matrixLabelInfo.Text = "";
        }

        private void matrixStartBtn_Click(object sender, EventArgs e)
        {
            resetBtn_Click(sender, e);
            int i, j;
            resetMatrixBtn.Enabled = true;
            int max = Convert.ToInt32(maxRangeNumericUpDown.Value);
            int min = Convert.ToInt32(minRangeNumericUpDown.Value);

            if (max < min)
            {
                matrixLabelInfo.Text = "Макс значение не может быть меньше мин значения!";
                return;
            }

            this.n = Convert.ToInt32(dimensionNumericUpDown.Value);
            this.m = this.n;

            int[,] ptr;
            ptr = new int[m, n];

            Random rnd = new Random();
            defaultMatrixDataGridView.ColumnCount = n;

            for (i = 0; i < n; i++)
            {
                defaultMatrixDataGridView.Rows.Add();
                for (j = 0; j < m; j++)
                {
                    ptr[i, j] = rnd.Next(min, max);
                    defaultMatrixDataGridView.Rows[i].Cells[j].Value = ptr[i, j];
                }
            }
            defaultMatrixDataGridView.AutoResizeColumns();

            this.ptr = ptr;

            if (useTaskLogicCheckBox.Checked)
            {
                this.taskLogic(ptr);
            }
            else
            {
                this.defaultLogic(ptr);
            }

        }

        // удаляет в результируещей матрице столбцы у которой под главной диагональю есть нули и в последнем столбце выводит сумму всех значений строки
        private void taskLogic(int[,] ptr)
        {
            // первое число отвечает за строку, второе за произведение
            int? invalidLine = null;
            int minValue = int.MaxValue;
            List<int> invalidLines = new List<int>();


            for (int currentLine = 0; currentLine < this.n; currentLine++)
            {
                // произведение чисел строки
                int productOfNumbers = 1;
                for (int column = 0; column < this.m; column++)
                {
                    productOfNumbers *= ptr[currentLine, column];
                }

                if (minValue > productOfNumbers)
                {
                    minValue = productOfNumbers;
                    invalidLine = currentLine;
                    invalidLines.Add(currentLine);
                }
            }

            // генерация нового массива с удалённой строкой
            int?[,] resultArray = new int?[this.n, this.m];
            for (int currentLine = 0; currentLine < this.n; currentLine++)
            {
                for (int column = 0; column < this.m; column++)
                {
                    if (invalidLines.FindIndex(x => x == currentLine) != -1)
                    {
                        resultArray[currentLine, column] = null;
                    }
                    else
                    {
                        resultArray[currentLine, column] = ptr[currentLine, column];
                    }
                }
            }

            int countDeleted = invalidLines.ToArray().Length;
            moveNullLineToSecondLine(ref resultArray, countDeleted);

            fillResultTaskMatrix(invalidLines, resultArray);
        }

        private void fillResultTaskMatrix(List<int> invalidLines, int?[,] resultArray)
        {
            // Разность среди строки первой и последней
            List<int> difference = new List<int>();

            for (int column = 0; column < this.m; column++)
            {
                difference.Add(ptr[0, column] - ptr[this.n - 1, column]);
            }

            resultMatrixDataGridView.Rows.Clear();
            resultMatrixDataGridView.ColumnCount = this.m;

            for (int currentLine = 0; currentLine <= this.n - 1; currentLine++)
            {
                int newCurrentLine = currentLine;

                resultMatrixDataGridView.Rows.Add();

                if (currentLine == 1)
                {
                    for (int column = 0; column < this.m; column++)
                    {
                        if (invalidLines.FindIndex(x => x == currentLine) != -1)
                        {
                            defaultMatrixDataGridView.Rows[currentLine].Cells[column].Style.BackColor = System.Drawing.Color.OrangeRed;
                        }
                        resultMatrixDataGridView.Rows[currentLine].Cells[column].Value = difference.ToArray()[column];
                    }
                    continue;
                }

                for (int column = 0; column < this.m; column++)
                {
                    if (invalidLines.FindIndex(x => x == currentLine) != -1)
                    {
                        defaultMatrixDataGridView.Rows[currentLine].Cells[column].Style.BackColor = System.Drawing.Color.OrangeRed;
                    }

                    resultMatrixDataGridView.Rows[newCurrentLine].Cells[column].Value = resultArray[currentLine, column];
                }
            }
            resultMatrixDataGridView.AutoResizeColumns();
        }

        // перемещает null-овую строчку на вторую строчку
        private void moveNullLineToSecondLine(ref int?[,] arr, int countDeleted)
        {
            for (int currentLine = 0; currentLine < this.n; currentLine++)
            {
                for (int column = 0; column < this.m; column++)
                {
                    if (arr[currentLine, column] == null && currentLine == 0)
                    {
                        arr[currentLine, column] = arr[currentLine + 1, column];
                        arr[currentLine + 1, column] = null;
                    }
                    else if (arr[currentLine, column] == null && currentLine > 1)
                    {
                        int? tmp = arr[currentLine - 1, column];
                        arr[currentLine, column] = tmp;
                        arr[currentLine - 1, column] = null;
                    }
                }
            }

            for (int column = 0; column < this.m; column++)
            {
                if (arr[1, column] != null)
                {
                    moveNullLineToSecondLine(ref arr, countDeleted);
                    return;
                }
            }
        }

        private void defaultLogic(int[,] ptr)
        {
            int i, j, k, q;

            k = 0;
            if (ptr[n - 1, m - 1] < 0) k++;

            for (q = 0; q < n - 1; q++)
            {
                if (ptr[q, m - 1] < 0)
                {
                    k++;
                    for (i = q; i < n - 1; i++)
                    {
                        for (j = 0; j < m; j++) ptr[i, j] = ptr[i + 1, j];

                    }
                    q--;
                }
                if (k + q + 1 == n) { break; }
            }
            if (k == n)
            {
                matrixLabelInfo.Text = "В матрице удалены все строки";
                return;
            }
            if (k == 0)
            {
                matrixLabelInfo.Text = "В матрице нет удаленных строк";
                return;
            }
            matrixLabelInfo.Text = "В матрице удалено " + k + " строк(и)";
            for (j = 0; j < m; j++)
            {
                ptr[n - k, j] = 0;
                for (i = 0; i < n - k; i++)
                {
                    ptr[n - k, j] += ptr[i, j];
                }
            }
            resultMatrixDataGridView.ColumnCount = n;
            for (i = 0; i <= n - k; i++)
            {
                resultMatrixDataGridView.Rows.Add();
                for (j = 0; j < m; j++)
                {
                    resultMatrixDataGridView.Rows[i].Cells[j].Value = ptr[i, j];
                }
            }
            resultMatrixDataGridView.AutoResizeColumns();

        }
    }
}
