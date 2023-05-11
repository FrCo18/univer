namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.arraysTab = new System.Windows.Forms.TabPage();
            this.arraysStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.arrayTabControl = new System.Windows.Forms.TabControl();
            this.testingAndUsingTab = new System.Windows.Forms.TabPage();
            this.resetBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.arraysDataGridView = new System.Windows.Forms.DataGridView();
            this.minNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stepNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inChartsCheckBox = new System.Windows.Forms.CheckBox();
            this.inTableCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartsTab = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.matrixTab = new System.Windows.Forms.TabPage();
            this.useTaskLogicCheckBox = new System.Windows.Forms.CheckBox();
            this.matrixLabelInfo = new System.Windows.Forms.Label();
            this.resultMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.defaultMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.resetMatrixBtn = new System.Windows.Forms.Button();
            this.matrixStartBtn = new System.Windows.Forms.Button();
            this.minRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dimensionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.matrixStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.arraysTab.SuspendLayout();
            this.arraysStatusStrip.SuspendLayout();
            this.arrayTabControl.SuspendLayout();
            this.testingAndUsingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraysDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown)).BeginInit();
            this.chartsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.matrixTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultMatrixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultMatrixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionNumericUpDown)).BeginInit();
            this.matrixStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.arraysTab);
            this.mainTabControl.Controls.Add(this.matrixTab);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(868, 538);
            this.mainTabControl.TabIndex = 0;
            // 
            // arraysTab
            // 
            this.arraysTab.Controls.Add(this.arraysStatusStrip);
            this.arraysTab.Controls.Add(this.arrayTabControl);
            this.arraysTab.Location = new System.Drawing.Point(4, 22);
            this.arraysTab.Name = "arraysTab";
            this.arraysTab.Padding = new System.Windows.Forms.Padding(3);
            this.arraysTab.Size = new System.Drawing.Size(860, 512);
            this.arraysTab.TabIndex = 0;
            this.arraysTab.Text = "Массивы";
            this.arraysTab.UseVisualStyleBackColor = true;
            // 
            // arraysStatusStrip
            // 
            this.arraysStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.arraysStatusStrip.Location = new System.Drawing.Point(3, 487);
            this.arraysStatusStrip.Name = "arraysStatusStrip";
            this.arraysStatusStrip.Size = new System.Drawing.Size(854, 22);
            this.arraysStatusStrip.TabIndex = 1;
            this.arraysStatusStrip.Text = "arraysStatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(569, 17);
            this.toolStripStatusLabel1.Text = "Нули удалить, положительные элементы расставить по убыванию, а отрицательные по в" +
    "озрастанию";
            // 
            // arrayTabControl
            // 
            this.arrayTabControl.Controls.Add(this.testingAndUsingTab);
            this.arrayTabControl.Controls.Add(this.chartsTab);
            this.arrayTabControl.Location = new System.Drawing.Point(6, 6);
            this.arrayTabControl.Name = "arrayTabControl";
            this.arrayTabControl.SelectedIndex = 0;
            this.arrayTabControl.Size = new System.Drawing.Size(848, 478);
            this.arrayTabControl.TabIndex = 0;
            // 
            // testingAndUsingTab
            // 
            this.testingAndUsingTab.Controls.Add(this.resetBtn);
            this.testingAndUsingTab.Controls.Add(this.startBtn);
            this.testingAndUsingTab.Controls.Add(this.infoLabel);
            this.testingAndUsingTab.Controls.Add(this.progressBar);
            this.testingAndUsingTab.Controls.Add(this.arraysDataGridView);
            this.testingAndUsingTab.Controls.Add(this.minNumericUpDown);
            this.testingAndUsingTab.Controls.Add(this.maxNumericUpDown);
            this.testingAndUsingTab.Controls.Add(this.stepNumericUpDown);
            this.testingAndUsingTab.Controls.Add(this.endNumericUpDown);
            this.testingAndUsingTab.Controls.Add(this.startNumericUpDown);
            this.testingAndUsingTab.Controls.Add(this.inChartsCheckBox);
            this.testingAndUsingTab.Controls.Add(this.inTableCheckBox);
            this.testingAndUsingTab.Controls.Add(this.label7);
            this.testingAndUsingTab.Controls.Add(this.label6);
            this.testingAndUsingTab.Controls.Add(this.label5);
            this.testingAndUsingTab.Controls.Add(this.label4);
            this.testingAndUsingTab.Controls.Add(this.label3);
            this.testingAndUsingTab.Controls.Add(this.label2);
            this.testingAndUsingTab.Controls.Add(this.label1);
            this.testingAndUsingTab.Location = new System.Drawing.Point(4, 22);
            this.testingAndUsingTab.Name = "testingAndUsingTab";
            this.testingAndUsingTab.Padding = new System.Windows.Forms.Padding(3);
            this.testingAndUsingTab.Size = new System.Drawing.Size(840, 452);
            this.testingAndUsingTab.TabIndex = 0;
            this.testingAndUsingTab.Text = "Тестирование и использование";
            this.testingAndUsingTab.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(622, 78);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 18;
            this.resetBtn.Text = "СБРОС";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(622, 49);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 17;
            this.startBtn.Text = "ПУСК";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(248, 415);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(368, 13);
            this.infoLabel.TabIndex = 16;
            this.infoLabel.Text = "Макс значение не м.б. меньше мин значения!, В массиве только нули!";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(93, 389);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(659, 23);
            this.progressBar.TabIndex = 15;
            // 
            // arraysDataGridView
            // 
            this.arraysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arraysDataGridView.Location = new System.Drawing.Point(23, 128);
            this.arraysDataGridView.Name = "arraysDataGridView";
            this.arraysDataGridView.Size = new System.Drawing.Size(796, 255);
            this.arraysDataGridView.TabIndex = 14;
            // 
            // minNumericUpDown
            // 
            this.minNumericUpDown.Location = new System.Drawing.Point(387, 77);
            this.minNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minNumericUpDown.Name = "minNumericUpDown";
            this.minNumericUpDown.Size = new System.Drawing.Size(78, 20);
            this.minNumericUpDown.TabIndex = 13;
            // 
            // maxNumericUpDown
            // 
            this.maxNumericUpDown.Location = new System.Drawing.Point(387, 47);
            this.maxNumericUpDown.Name = "maxNumericUpDown";
            this.maxNumericUpDown.Size = new System.Drawing.Size(78, 20);
            this.maxNumericUpDown.TabIndex = 12;
            // 
            // stepNumericUpDown
            // 
            this.stepNumericUpDown.Location = new System.Drawing.Point(174, 102);
            this.stepNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepNumericUpDown.Name = "stepNumericUpDown";
            this.stepNumericUpDown.Size = new System.Drawing.Size(78, 20);
            this.stepNumericUpDown.TabIndex = 11;
            this.stepNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endNumericUpDown
            // 
            this.endNumericUpDown.Location = new System.Drawing.Point(174, 76);
            this.endNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.endNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.endNumericUpDown.Name = "endNumericUpDown";
            this.endNumericUpDown.Size = new System.Drawing.Size(78, 20);
            this.endNumericUpDown.TabIndex = 10;
            this.endNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // startNumericUpDown
            // 
            this.startNumericUpDown.Location = new System.Drawing.Point(174, 47);
            this.startNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.startNumericUpDown.Name = "startNumericUpDown";
            this.startNumericUpDown.Size = new System.Drawing.Size(78, 20);
            this.startNumericUpDown.TabIndex = 9;
            this.startNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // inChartsCheckBox
            // 
            this.inChartsCheckBox.AutoSize = true;
            this.inChartsCheckBox.Location = new System.Drawing.Point(494, 77);
            this.inChartsCheckBox.Name = "inChartsCheckBox";
            this.inChartsCheckBox.Size = new System.Drawing.Size(79, 17);
            this.inChartsCheckBox.TabIndex = 8;
            this.inChartsCheckBox.Text = "В графики";
            this.inChartsCheckBox.UseVisualStyleBackColor = true;
            // 
            // inTableCheckBox
            // 
            this.inTableCheckBox.AutoSize = true;
            this.inTableCheckBox.Location = new System.Drawing.Point(494, 50);
            this.inTableCheckBox.Name = "inTableCheckBox";
            this.inTableCheckBox.Size = new System.Drawing.Size(76, 17);
            this.inTableCheckBox.TabIndex = 7;
            this.inTableCheckBox.Text = "В таблицу";
            this.inTableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Шаг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Конечный";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начальный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(355, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Диапазон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер";
            // 
            // chartsTab
            // 
            this.chartsTab.Controls.Add(this.chart2);
            this.chartsTab.Controls.Add(this.chart1);
            this.chartsTab.Location = new System.Drawing.Point(4, 22);
            this.chartsTab.Name = "chartsTab";
            this.chartsTab.Padding = new System.Windows.Forms.Padding(3);
            this.chartsTab.Size = new System.Drawing.Size(840, 452);
            this.chartsTab.TabIndex = 1;
            this.chartsTab.Text = "Графики";
            this.chartsTab.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(6, 240);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Количество обменов";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(828, 206);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "Количество сравнений";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 6);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Количество сравнений";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(831, 213);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Количество сравнений";
            // 
            // matrixTab
            // 
            this.matrixTab.Controls.Add(this.useTaskLogicCheckBox);
            this.matrixTab.Controls.Add(this.matrixLabelInfo);
            this.matrixTab.Controls.Add(this.resultMatrixDataGridView);
            this.matrixTab.Controls.Add(this.defaultMatrixDataGridView);
            this.matrixTab.Controls.Add(this.resetMatrixBtn);
            this.matrixTab.Controls.Add(this.matrixStartBtn);
            this.matrixTab.Controls.Add(this.minRangeNumericUpDown);
            this.matrixTab.Controls.Add(this.maxRangeNumericUpDown);
            this.matrixTab.Controls.Add(this.dimensionNumericUpDown);
            this.matrixTab.Controls.Add(this.matrixStatusStrip);
            this.matrixTab.Controls.Add(this.label13);
            this.matrixTab.Controls.Add(this.label12);
            this.matrixTab.Controls.Add(this.label11);
            this.matrixTab.Controls.Add(this.label10);
            this.matrixTab.Controls.Add(this.label9);
            this.matrixTab.Controls.Add(this.label8);
            this.matrixTab.Location = new System.Drawing.Point(4, 22);
            this.matrixTab.Name = "matrixTab";
            this.matrixTab.Padding = new System.Windows.Forms.Padding(3);
            this.matrixTab.Size = new System.Drawing.Size(860, 512);
            this.matrixTab.TabIndex = 1;
            this.matrixTab.Text = "Матрицы";
            this.matrixTab.UseVisualStyleBackColor = true;
            // 
            // useTaskLogicCheckBox
            // 
            this.useTaskLogicCheckBox.AutoSize = true;
            this.useTaskLogicCheckBox.Location = new System.Drawing.Point(294, 252);
            this.useTaskLogicCheckBox.Name = "useTaskLogicCheckBox";
            this.useTaskLogicCheckBox.Size = new System.Drawing.Size(328, 17);
            this.useTaskLogicCheckBox.TabIndex = 15;
            this.useTaskLogicCheckBox.Text = "Использовать логику задания по вариантам (2-ой вариант)";
            this.useTaskLogicCheckBox.UseVisualStyleBackColor = true;
            // 
            // matrixLabelInfo
            // 
            this.matrixLabelInfo.AutoSize = true;
            this.matrixLabelInfo.Location = new System.Drawing.Point(396, 296);
            this.matrixLabelInfo.Name = "matrixLabelInfo";
            this.matrixLabelInfo.Size = new System.Drawing.Size(51, 13);
            this.matrixLabelInfo.TabIndex = 14;
            this.matrixLabelInfo.Text = "LabelInfo";
            // 
            // resultMatrixDataGridView
            // 
            this.resultMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultMatrixDataGridView.Location = new System.Drawing.Point(399, 317);
            this.resultMatrixDataGridView.Name = "resultMatrixDataGridView";
            this.resultMatrixDataGridView.Size = new System.Drawing.Size(432, 150);
            this.resultMatrixDataGridView.TabIndex = 13;
            // 
            // defaultMatrixDataGridView
            // 
            this.defaultMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defaultMatrixDataGridView.Location = new System.Drawing.Point(399, 30);
            this.defaultMatrixDataGridView.Name = "defaultMatrixDataGridView";
            this.defaultMatrixDataGridView.Size = new System.Drawing.Size(432, 170);
            this.defaultMatrixDataGridView.TabIndex = 12;
            // 
            // resetMatrixBtn
            // 
            this.resetMatrixBtn.Location = new System.Drawing.Point(193, 291);
            this.resetMatrixBtn.Name = "resetMatrixBtn";
            this.resetMatrixBtn.Size = new System.Drawing.Size(75, 23);
            this.resetMatrixBtn.TabIndex = 11;
            this.resetMatrixBtn.Text = "Сброс";
            this.resetMatrixBtn.UseVisualStyleBackColor = true;
            this.resetMatrixBtn.Click += new System.EventHandler(this.resetMatrixBtn_Click);
            // 
            // matrixStartBtn
            // 
            this.matrixStartBtn.Location = new System.Drawing.Point(193, 248);
            this.matrixStartBtn.Name = "matrixStartBtn";
            this.matrixStartBtn.Size = new System.Drawing.Size(75, 23);
            this.matrixStartBtn.TabIndex = 10;
            this.matrixStartBtn.Text = "Старт";
            this.matrixStartBtn.UseVisualStyleBackColor = true;
            this.matrixStartBtn.Click += new System.EventHandler(this.matrixStartBtn_Click);
            // 
            // minRangeNumericUpDown
            // 
            this.minRangeNumericUpDown.Location = new System.Drawing.Point(193, 180);
            this.minRangeNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minRangeNumericUpDown.Name = "minRangeNumericUpDown";
            this.minRangeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.minRangeNumericUpDown.TabIndex = 9;
            // 
            // maxRangeNumericUpDown
            // 
            this.maxRangeNumericUpDown.Location = new System.Drawing.Point(193, 139);
            this.maxRangeNumericUpDown.Name = "maxRangeNumericUpDown";
            this.maxRangeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxRangeNumericUpDown.TabIndex = 8;
            // 
            // dimensionNumericUpDown
            // 
            this.dimensionNumericUpDown.Location = new System.Drawing.Point(193, 43);
            this.dimensionNumericUpDown.Name = "dimensionNumericUpDown";
            this.dimensionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.dimensionNumericUpDown.TabIndex = 7;
            // 
            // matrixStatusStrip
            // 
            this.matrixStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.matrixStatusStrip.Location = new System.Drawing.Point(3, 487);
            this.matrixStatusStrip.Name = "matrixStatusStrip";
            this.matrixStatusStrip.Size = new System.Drawing.Size(854, 22);
            this.matrixStatusStrip.TabIndex = 6;
            this.matrixStatusStrip.Text = "matrixStatusStrip";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(441, 17);
            this.toolStripStatusLabel2.Text = "Строки с \"-\" на конце - удалить, а затем добавить строку из сумм по столбцам";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(396, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Матрица - результат";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(396, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Исходная матрица";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(33, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Диапазон чисел";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Размерность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 552);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Массивы";
            this.mainTabControl.ResumeLayout(false);
            this.arraysTab.ResumeLayout(false);
            this.arraysTab.PerformLayout();
            this.arraysStatusStrip.ResumeLayout(false);
            this.arraysStatusStrip.PerformLayout();
            this.arrayTabControl.ResumeLayout(false);
            this.testingAndUsingTab.ResumeLayout(false);
            this.testingAndUsingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraysDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown)).EndInit();
            this.chartsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.matrixTab.ResumeLayout(false);
            this.matrixTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultMatrixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultMatrixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionNumericUpDown)).EndInit();
            this.matrixStatusStrip.ResumeLayout(false);
            this.matrixStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage arraysTab;
        private System.Windows.Forms.TabPage matrixTab;
        private System.Windows.Forms.TabControl arrayTabControl;
        private System.Windows.Forms.TabPage testingAndUsingTab;
        private System.Windows.Forms.TabPage chartsTab;
        private System.Windows.Forms.StatusStrip arraysStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView arraysDataGridView;
        private System.Windows.Forms.NumericUpDown minNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxNumericUpDown;
        private System.Windows.Forms.NumericUpDown stepNumericUpDown;
        private System.Windows.Forms.NumericUpDown endNumericUpDown;
        private System.Windows.Forms.NumericUpDown startNumericUpDown;
        private System.Windows.Forms.CheckBox inChartsCheckBox;
        private System.Windows.Forms.CheckBox inTableCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.StatusStrip matrixStatusStrip;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView resultMatrixDataGridView;
        private System.Windows.Forms.DataGridView defaultMatrixDataGridView;
        private System.Windows.Forms.Button resetMatrixBtn;
        private System.Windows.Forms.Button matrixStartBtn;
        private System.Windows.Forms.NumericUpDown minRangeNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxRangeNumericUpDown;
        private System.Windows.Forms.NumericUpDown dimensionNumericUpDown;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label matrixLabelInfo;
        private System.Windows.Forms.CheckBox useTaskLogicCheckBox;
    }
}

