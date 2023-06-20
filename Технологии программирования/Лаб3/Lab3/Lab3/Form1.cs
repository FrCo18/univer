using Sorting;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            labelLog.Text = "";
            recursionFunctionToolStripMenuItem.Enabled = false;
            chartSelect.Series[0].BorderWidth = 3;
            chartSelect.Series[0].Color = Color.Red;
            chartSelect.Series[1].BorderWidth = 3;
            chartSelect.Series[1].Color = Color.Blue;
            chartSelect.Series[0].LegendText = "Сравнения";
            chartSelect.Series[1].LegendText = "Обмены";

            chartInsert.Series[0].BorderWidth = 3;
            chartInsert.Series[0].Color = Color.Red;
            chartInsert.Series[1].BorderWidth = 3;
            chartInsert.Series[1].Color = Color.Blue;
            chartInsert.Series[0].LegendText = "Сравнения";
            chartInsert.Series[1].LegendText = "Обмены";

            chartBubble.Series[0].BorderWidth = 3;
            chartBubble.Series[0].Color = Color.Red;
            chartBubble.Series[1].BorderWidth = 3;
            chartBubble.Series[1].Color = Color.Blue;
            chartBubble.Series[0].LegendText = "Сравнения";
            chartBubble.Series[1].LegendText = "Обмены";

            // quick + bubble recursive
            chartQuick.Series[0].BorderWidth = 3;
            chartQuick.Series[0].Color = Color.Red;
            chartQuick.Series[1].BorderWidth = 3;
            chartQuick.Series[1].Color = Color.Blue;
            chartQuick.Series[0].LegendText = "Сравнения быстрая";
            chartQuick.Series[1].LegendText = "Обмены быстрая";

            chartQuick.Series[2].BorderWidth = 3;
            chartQuick.Series[2].Color = Color.Green;
            chartQuick.Series[3].BorderWidth = 3;
            chartQuick.Series[3].Color = Color.Yellow;
            chartQuick.Series[2].LegendText = "Сравнения (пузырёк рекурсив)";
            chartQuick.Series[3].LegendText = "Обмены (пузырёк рекурсив)";

            // bubble + bubble recursive
            chartBubbles.Series[0].BorderWidth = 3;
            chartBubbles.Series[0].Color = Color.Red;
            chartBubbles.Series[1].BorderWidth = 3;
            chartBubbles.Series[1].Color = Color.Blue;
            chartBubbles.Series[0].LegendText = "Сравнения пузырёк";
            chartBubbles.Series[1].LegendText = "Обмены пузырёк";

            chartBubbles.Series[2].BorderWidth = 3;
            chartBubbles.Series[2].Color = Color.Green;
            chartBubbles.Series[3].BorderWidth = 3;
            chartBubbles.Series[3].Color = Color.Yellow;
            chartBubbles.Series[2].LegendText = "Сравнения (пузырёк рекурсив)";
            chartBubbles.Series[3].LegendText = "Обмены (пузырёк рекурсив)";
        }

        //вывод массива в textBox
        public void outputTextBox(int[] out_a, int n)
        {
            for (int i = 0; i < n; i++)
            { textBox.Text += out_a[i] + " "; }
            textBox.Text += Environment.NewLine;
        }

        //вывод в таблицу кол-ва сравнений и обменов
        public void output_dataGridView(int count, int sr, int obm, int vid_sort)
        {
            dataGridView1.Rows[count].Cells[vid_sort].Value = sr;
            dataGridView2.Rows[count].Cells[vid_sort].Value = obm;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "Размер";
            dataGridView1.Columns[1].HeaderText = "Выбор";
            dataGridView1.Columns[2].HeaderText = "Вставки";
            dataGridView1.Columns[3].HeaderText = "Пузырек";
            dataGridView1.Columns[4].HeaderText = "Быстрая";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns[0].HeaderText = "Размер";
            dataGridView2.Columns[1].HeaderText = "Выбор";
            dataGridView2.Columns[2].HeaderText = "Вставки";
            dataGridView2.Columns[3].HeaderText = "Пузырек";
            dataGridView2.Columns[4].HeaderText = "Быстрая + Пузырьком (рекурсив)";
            dataGridView2.Columns[5].HeaderText = "Пузырёк + Пузырьком (рекурсив)";
            dataGridView1.ColumnCount = 6;
            dataGridView2.ColumnCount = 6;
            labelLog.Text = "";
            if (numericUpDownRangeMax.Value < numericUpDownRangeMin.Value)
            { labelLog.Text = "Макс значение не м.б. меньше мин значения!"; return; }
            int count = 0, n, sr = 0, obm = 0;
            ArraySort sortSelect = new ArraySort();
            ArraySort sortInsert = new ArraySort();
            ArraySort sortBubble = new ArraySort();
            ArraySort quickSort = new ArraySort();
            ArraySort bubleSortRecursive = new ArraySort();
            for (n = Convert.ToInt32(numericUpDownSizeMin.Value); n <=
           Convert.ToInt32(numericUpDownSizeMax.Value); n += Convert.ToInt32(numericUpDownStep.Value))
            {
                int[] base_a = new int[n];
                Random rand = new Random();
                for (int j = 0; j < n; j++)
                {
                    base_a[j] = rand.Next(Convert.ToInt32(numericUpDownRangeMin.Value),
                   Convert.ToInt32(numericUpDownRangeMax.Value));
                }

                textBox.Text += "Исходный массив " + Environment.NewLine;
                outputTextBox(base_a, n);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[count].Cells[0].Value = n;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[count].Cells[0].Value = n;

                sortSelect.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sortSelect.selectSort(sortSelect.a, ref sr, ref obm);
                textBox.Text += "Сортировка выбором " + Environment.NewLine;
                outputTextBox(sortSelect.a, n);
                output_dataGridView(count, sr, obm, 1);
                chartSelect.Series[0].Points.AddXY(n, sr);
                chartSelect.Series[1].Points.AddXY(n, obm);

                sortInsert.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                sortInsert.insertSort(sortInsert.a, ref sr, ref obm);
                textBox.Text += "Сортировка вставками " + Environment.NewLine;
                outputTextBox(sortInsert.a, n);
                output_dataGridView(count, sr, obm, 2);
                chartInsert.Series[0].Points.AddXY(n, sr);
                chartInsert.Series[1].Points.AddXY(n, obm);

                sortBubble.a = (int[])base_a.Clone();
                int srBubble = 0; int obmBubble = 0;
                sortBubble.bubbleSort(sortBubble.a, ref srBubble, ref obmBubble);
                textBox.Text += "Сортировка пузырьком " + Environment.NewLine;
                outputTextBox(sortBubble.a, n);
                output_dataGridView(count, srBubble, obmBubble, 3);
                chartBubble.Series[0].Points.AddXY(n, srBubble);
                chartBubble.Series[1].Points.AddXY(n, obmBubble);

                // quick + bubble recursive
                quickSort.a = (int[])base_a.Clone();
                sr = 0; obm = 0;
                quickSort.quickSort(quickSort.a, ref sr, ref obm);
                textBox.Text += "Сортировка быстрая " + Environment.NewLine;
                outputTextBox(quickSort.a, n);
                output_dataGridView(count, sr, obm, 4);
                chartQuick.Series[0].Points.AddXY(n, sr);
                chartQuick.Series[1].Points.AddXY(n, obm);

                bubleSortRecursive.a = (int[])base_a.Clone();
                int srBubbleRecursive = 0; int obmBubbleRecursive = 0;
                bubleSortRecursive.bubbleSortRecursive(bubleSortRecursive.a, bubleSortRecursive.a.Length, ref srBubbleRecursive, ref obmBubbleRecursive);
                textBox.Text += "Сортировка пузырьком (рекурсив)" + Environment.NewLine;
                outputTextBox(bubleSortRecursive.a, n);
                output_dataGridView(count, srBubbleRecursive, obmBubbleRecursive, 4);
                chartQuick.Series[2].Points.AddXY(n, srBubbleRecursive);
                chartQuick.Series[3].Points.AddXY(n, obmBubbleRecursive);

                // bubble + bubble recursive
                textBox.Text += "Сортировка пузырёк " + Environment.NewLine;
                outputTextBox(sortBubble.a, n);
                output_dataGridView(count, srBubble, obmBubble, 5);
                chartBubbles.Series[0].Points.AddXY(n, srBubble);
                chartBubbles.Series[1].Points.AddXY(n, obmBubble);

                textBox.Text += "Сортировка пузырьком (рекурсив)" + Environment.NewLine;
                outputTextBox(bubleSortRecursive.a, n);
                output_dataGridView(count, srBubbleRecursive, obmBubbleRecursive, 5);
                chartBubbles.Series[2].Points.AddXY(n, srBubbleRecursive);
                chartBubbles.Series[3].Points.AddXY(n, obmBubbleRecursive);
                count++;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            textBox.Text = "";
            buttonStart.Enabled = true;
            loopToolStripMenuItem.Enabled = true;
            chartSelect.Series[0].Points.Clear();
            chartSelect.Series[1].Points.Clear();

            chartInsert.Series[0].Points.Clear();
            chartInsert.Series[1].Points.Clear();

            chartBubble.Series[0].Points.Clear();
            chartBubble.Series[1].Points.Clear();

            chartQuick.Series[0].Points.Clear();
            chartQuick.Series[1].Points.Clear();
            chartQuick.Series[2].Points.Clear();
            chartQuick.Series[3].Points.Clear();

            chartBubbles.Series[0].Points.Clear();
            chartBubbles.Series[1].Points.Clear();
            chartBubbles.Series[2].Points.Clear();
            chartBubbles.Series[3].Points.Clear();
        }

        private void saveAllChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveChartInsertToolStripMenuItem_Click(sender, e);
            saveChartSelectToolStripMenuItem_Click(sender, e);
            saveChartBubbleToolStripMenuItem_Click(sender, e);
        }

        private void saveChartInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr1 = new SaveFileDialog())
            {
                saveGr1.Title = "Сохранить график как ...";
                saveGr1.Filter = "*.jpg|*.jpg";
                saveGr1.AddExtension = true;
                saveGr1.FileName = "Insert";
                if (saveGr1.ShowDialog() == DialogResult.OK)
                {
                    chartInsert.SaveImage(saveGr1.FileName, ChartImageFormat.Png);
                }
            }
        }

        private void saveChartSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr = new SaveFileDialog())
            {
                saveGr.Title = "Сохранить график как ...";
                saveGr.Filter = "*.jpg|*.jpg";
                saveGr.AddExtension = true;
                saveGr.FileName = "Select";
                if (saveGr.ShowDialog() == DialogResult.OK)
                {
                    chartSelect.SaveImage(saveGr.FileName, ChartImageFormat.Png);
                }
            }
        }

        private void saveChartBubbleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr2 = new SaveFileDialog())
            {
                saveGr2.Title = "Сохранить график как ...";
                saveGr2.Filter = "*.jpg|*.jpg";
                saveGr2.AddExtension = true;
                saveGr2.FileName = "Bubble";
                if (saveGr2.ShowDialog() == DialogResult.OK)
                {
                    chartBubble.SaveImage(saveGr2.FileName, ChartImageFormat.Png);
                }
            }
        }

        private void loopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonStart_Click(sender, e);
            loopToolStripMenuItem.Enabled = false;
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNote help = new FormNote();
            help.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
