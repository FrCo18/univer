namespace Lab2
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.textBoxSecondWord = new System.Windows.Forms.TextBox();
            this.textBoxFirstWord = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.findFirstBtn = new System.Windows.Forms.Button();
            this.changeWordsBtn = new System.Windows.Forms.Button();
            this.findSecondBtn = new System.Windows.Forms.Button();
            this.selectVowelLettersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 70);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(255, 341);
            this.textBoxLog.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(551, 70);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(237, 341);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // textBoxSecondWord
            // 
            this.textBoxSecondWord.Location = new System.Drawing.Point(347, 248);
            this.textBoxSecondWord.Name = "textBoxSecondWord";
            this.textBoxSecondWord.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondWord.TabIndex = 2;
            // 
            // textBoxFirstWord
            // 
            this.textBoxFirstWord.Location = new System.Drawing.Point(347, 133);
            this.textBoxFirstWord.Name = "textBoxFirstWord";
            this.textBoxFirstWord.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstWord.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(347, 70);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // findFirstBtn
            // 
            this.findFirstBtn.Location = new System.Drawing.Point(347, 182);
            this.findFirstBtn.Name = "findFirstBtn";
            this.findFirstBtn.Size = new System.Drawing.Size(100, 23);
            this.findFirstBtn.TabIndex = 5;
            this.findFirstBtn.Text = "Найти первое";
            this.findFirstBtn.UseVisualStyleBackColor = true;
            this.findFirstBtn.Click += new System.EventHandler(this.findFirstBtn_Click);
            // 
            // changeWordsBtn
            // 
            this.changeWordsBtn.Enabled = false;
            this.changeWordsBtn.Location = new System.Drawing.Point(347, 337);
            this.changeWordsBtn.Name = "changeWordsBtn";
            this.changeWordsBtn.Size = new System.Drawing.Size(100, 23);
            this.changeWordsBtn.TabIndex = 6;
            this.changeWordsBtn.Text = "Поменять";
            this.changeWordsBtn.UseVisualStyleBackColor = true;
            this.changeWordsBtn.Click += new System.EventHandler(this.changeWordsBtn_Click);
            // 
            // findSecondBtn
            // 
            this.findSecondBtn.Location = new System.Drawing.Point(347, 295);
            this.findSecondBtn.Name = "findSecondBtn";
            this.findSecondBtn.Size = new System.Drawing.Size(100, 23);
            this.findSecondBtn.TabIndex = 7;
            this.findSecondBtn.Text = "Найти второе";
            this.findSecondBtn.UseVisualStyleBackColor = true;
            this.findSecondBtn.Click += new System.EventHandler(this.findSecondBtn_Click);
            // 
            // selectVowelLettersBtn
            // 
            this.selectVowelLettersBtn.Location = new System.Drawing.Point(273, 366);
            this.selectVowelLettersBtn.Name = "selectVowelLettersBtn";
            this.selectVowelLettersBtn.Size = new System.Drawing.Size(272, 57);
            this.selectVowelLettersBtn.TabIndex = 8;
            this.selectVowelLettersBtn.Text = "Выделить слово оканчивающее на глассную";
            this.selectVowelLettersBtn.UseVisualStyleBackColor = true;
            this.selectVowelLettersBtn.Click += new System.EventHandler(this.selectVowelLettersBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectVowelLettersBtn);
            this.Controls.Add(this.findSecondBtn);
            this.Controls.Add(this.changeWordsBtn);
            this.Controls.Add(this.findFirstBtn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.textBoxFirstWord);
            this.Controls.Add(this.textBoxSecondWord);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.textBoxLog);
            this.Name = "MainForm";
            this.Text = "Тектовые файлы, символы и строки";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox textBoxSecondWord;
        private System.Windows.Forms.TextBox textBoxFirstWord;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button findFirstBtn;
        private System.Windows.Forms.Button changeWordsBtn;
        private System.Windows.Forms.Button findSecondBtn;
        private System.Windows.Forms.Button selectVowelLettersBtn;
    }
}

