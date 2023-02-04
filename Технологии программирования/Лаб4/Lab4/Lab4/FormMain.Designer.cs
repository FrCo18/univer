namespace Lab4
{
    partial class FormMain
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
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAcademicDegree = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskOfVariantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBithdayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicDegreeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownExperience = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.radioButtonPost = new System.Windows.Forms.RadioButton();
            this.radioButtonExpirienceNotMin = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(6, 59);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(150, 20);
            this.textBoxFio.TabIndex = 0;
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(6, 107);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(150, 21);
            this.comboBoxPost.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBoxAcademicDegree
            // 
            this.comboBoxAcademicDegree.FormattingEnabled = true;
            this.comboBoxAcademicDegree.Location = new System.Drawing.Point(6, 223);
            this.comboBoxAcademicDegree.Name = "comboBoxAcademicDegree";
            this.comboBoxAcademicDegree.Size = new System.Drawing.Size(150, 21);
            this.comboBoxAcademicDegree.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 312);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.taskOfVariantToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataToolStripMenuItem,
            this.startQueryToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addDataToolStripMenuItem.Text = "Добавить данные";
            this.addDataToolStripMenuItem.Click += new System.EventHandler(this.addDataToolStripMenuItem_Click);
            // 
            // startQueryToolStripMenuItem
            // 
            this.startQueryToolStripMenuItem.Name = "startQueryToolStripMenuItem";
            this.startQueryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.startQueryToolStripMenuItem.Text = "Выполнить запрос";
            this.startQueryToolStripMenuItem.Click += new System.EventHandler(this.startQueryToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.leaveToolStripMenuItem_Click);
            // 
            // taskOfVariantToolStripMenuItem
            // 
            this.taskOfVariantToolStripMenuItem.Name = "taskOfVariantToolStripMenuItem";
            this.taskOfVariantToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.taskOfVariantToolStripMenuItem.Text = "Задание по варианту";
            this.taskOfVariantToolStripMenuItem.Click += new System.EventHandler(this.taskOfVariantToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioColumn,
            this.postColumn,
            this.dateOfBithdayColumn,
            this.academicDegreeColumn,
            this.experienceColumn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 260);
            this.dataGridView1.TabIndex = 10;
            // 
            // fioColumn
            // 
            this.fioColumn.HeaderText = "ФИО";
            this.fioColumn.Name = "fioColumn";
            // 
            // postColumn
            // 
            this.postColumn.HeaderText = "Должность";
            this.postColumn.Name = "postColumn";
            // 
            // dateOfBithdayColumn
            // 
            this.dateOfBithdayColumn.HeaderText = "Дата рождения";
            this.dateOfBithdayColumn.Name = "dateOfBithdayColumn";
            // 
            // academicDegreeColumn
            // 
            this.academicDegreeColumn.HeaderText = "Учёная степень";
            this.academicDegreeColumn.Name = "academicDegreeColumn";
            // 
            // experienceColumn
            // 
            this.experienceColumn.HeaderText = "Стаж";
            this.experienceColumn.Name = "experienceColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(6, 285);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(553, 265);
            this.dataGridView2.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Учёная степень";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Стаж";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownExperience);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxFio);
            this.groupBox1.Controls.Add(this.comboBoxPost);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.comboBoxAcademicDegree);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 371);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // numericUpDownExperience
            // 
            this.numericUpDownExperience.Location = new System.Drawing.Point(6, 285);
            this.numericUpDownExperience.Name = "numericUpDownExperience";
            this.numericUpDownExperience.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownExperience.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Стаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Учёная степень";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.buttonFind);
            this.groupBox2.Controls.Add(this.radioButtonPost);
            this.groupBox2.Controls.Add(this.radioButtonExpirienceNotMin);
            this.groupBox2.Location = new System.Drawing.Point(29, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 152);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запрос";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 14;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(22, 123);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(150, 23);
            this.buttonFind.TabIndex = 10;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // radioButtonPost
            // 
            this.radioButtonPost.AutoSize = true;
            this.radioButtonPost.Location = new System.Drawing.Point(22, 60);
            this.radioButtonPost.Name = "radioButtonPost";
            this.radioButtonPost.Size = new System.Drawing.Size(83, 17);
            this.radioButtonPost.TabIndex = 9;
            this.radioButtonPost.TabStop = true;
            this.radioButtonPost.Text = "Должность";
            this.radioButtonPost.UseVisualStyleBackColor = true;
            // 
            // radioButtonExpirienceNotMin
            // 
            this.radioButtonExpirienceNotMin.AutoSize = true;
            this.radioButtonExpirienceNotMin.Location = new System.Drawing.Point(22, 22);
            this.radioButtonExpirienceNotMin.Name = "radioButtonExpirienceNotMin";
            this.radioButtonExpirienceNotMin.Size = new System.Drawing.Size(101, 17);
            this.radioButtonExpirienceNotMin.TabIndex = 8;
            this.radioButtonExpirienceNotMin.TabStop = true;
            this.radioButtonExpirienceNotMin.Text = "Стаж не менее";
            this.radioButtonExpirienceNotMin.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(229, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 556);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Работа со структурами";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxAcademicDegree;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBithdayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicDegreeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.RadioButton radioButtonPost;
        private System.Windows.Forms.RadioButton radioButtonExpirienceNotMin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownExperience;
        private System.Windows.Forms.ToolStripMenuItem taskOfVariantToolStripMenuItem;
    }
}

