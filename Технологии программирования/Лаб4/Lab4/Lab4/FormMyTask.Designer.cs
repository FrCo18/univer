namespace Lab4
{
    partial class FormMyTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSchoolarship = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.fioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgMarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolarshipColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDowAvgMark = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numericUpDownAvgMarkForFilter = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgMarkColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchoolarship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowAvgMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvgMarkForFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 556);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioColumn,
            this.groupColumn,
            this.avgMarkColumn,
            this.schoolarshipColumn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 260);
            this.dataGridView1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownAvgMarkForFilter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonFind);
            this.groupBox2.Location = new System.Drawing.Point(18, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 152);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Вывести студентов с средним\r\nбалом превышающим следующий:";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(15, 114);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(150, 23);
            this.buttonFind.TabIndex = 10;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDowAvgMark);
            this.groupBox1.Controls.Add(this.textBoxGroup);
            this.groupBox1.Controls.Add(this.numericUpDownSchoolarship);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxFio);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 371);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // numericUpDownSchoolarship
            // 
            this.numericUpDownSchoolarship.Location = new System.Drawing.Point(6, 242);
            this.numericUpDownSchoolarship.Name = "numericUpDownSchoolarship";
            this.numericUpDownSchoolarship.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownSchoolarship.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Размер стипендии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Средний бал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Группа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО студента";
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(6, 59);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(150, 20);
            this.textBoxFio.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 269);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(6, 130);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(150, 20);
            this.textBoxGroup.TabIndex = 18;
            // 
            // fioColumn
            // 
            this.fioColumn.HeaderText = "ФИО";
            this.fioColumn.Name = "fioColumn";
            // 
            // groupColumn
            // 
            this.groupColumn.HeaderText = "Группа";
            this.groupColumn.Name = "groupColumn";
            // 
            // avgMarkColumn
            // 
            this.avgMarkColumn.HeaderText = "Средний бал";
            this.avgMarkColumn.Name = "avgMarkColumn";
            // 
            // schoolarshipColumn
            // 
            this.schoolarshipColumn.HeaderText = "Стипендия";
            this.schoolarshipColumn.Name = "schoolarshipColumn";
            // 
            // numericUpDowAvgMark
            // 
            this.numericUpDowAvgMark.DecimalPlaces = 1;
            this.numericUpDowAvgMark.Location = new System.Drawing.Point(6, 194);
            this.numericUpDowAvgMark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDowAvgMark.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDowAvgMark.Name = "numericUpDowAvgMark";
            this.numericUpDowAvgMark.Size = new System.Drawing.Size(150, 20);
            this.numericUpDowAvgMark.TabIndex = 19;
            this.numericUpDowAvgMark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.avgMarkColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(6, 296);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(553, 260);
            this.dataGridView2.TabIndex = 11;
            // 
            // numericUpDownAvgMarkForFilter
            // 
            this.numericUpDownAvgMarkForFilter.DecimalPlaces = 1;
            this.numericUpDownAvgMarkForFilter.Location = new System.Drawing.Point(15, 75);
            this.numericUpDownAvgMarkForFilter.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownAvgMarkForFilter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAvgMarkForFilter.Name = "numericUpDownAvgMarkForFilter";
            this.numericUpDownAvgMarkForFilter.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownAvgMarkForFilter.TabIndex = 20;
            this.numericUpDownAvgMarkForFilter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // avgMarkColumn2
            // 
            this.avgMarkColumn2.HeaderText = "Средний бал";
            this.avgMarkColumn2.Name = "avgMarkColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Стипендия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormMyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMyTask";
            this.Text = "FormMyTask";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSchoolarship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowAvgMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvgMarkForFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSchoolarship;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgMarkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolarshipColumn;
        private System.Windows.Forms.NumericUpDown numericUpDowAvgMark;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.NumericUpDown numericUpDownAvgMarkForFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgMarkColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}