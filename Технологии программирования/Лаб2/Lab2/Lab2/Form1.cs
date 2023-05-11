using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ContextMenu contextMenu1;
            contextMenu1 = new ContextMenu();
            MenuItem menuItem1;
            menuItem1 = new MenuItem();
            MenuItem menuItem2;
            menuItem2 = new MenuItem();
            MenuItem menuItem3;
            menuItem3 = new MenuItem();
            contextMenu1.MenuItems.AddRange(new MenuItem[] { menuItem1, menuItem2, menuItem3 });
            menuItem1.Index = 0;
            menuItem1.Text = "Открыть";
            menuItem2.Index = 1;
            menuItem2.Text = "Сохранить";
            menuItem3.Index = 2;
            menuItem3.Text = "Сохранить как";
            richTextBox.ContextMenu = contextMenu1;

            menuItem1.Click += new EventHandler(this.menuItem1_Click);
            menuItem2.Click += new EventHandler(this.menuItem2_Click);
            menuItem3.Click += new EventHandler(this.menuItem3_Click);
        }
        private string MyFName = "";

        private void menuItem3_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстовые файлы (*.rtf; *.txt; *.dat) | *.rtf;*.txt; *.dat";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MyFName = saveFileDialog.FileName;
                richTextBox.SaveFile(MyFName);
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (MyFName != "")
            {
                richTextBox.SaveFile(MyFName);
            }
            else
            {
                saveFileDialog.Filter = "Текстовые файлы (*.rtf; *.txt; *.dat) | *.rtf;*.txt; *.dat";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MyFName = saveFileDialog.FileName;
                    richTextBox.SaveFile(MyFName);
                }
            }

        }


        private void menuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Текстовые файлы (*.rtf; *.txt; *.dat) | *.rtf;*.txt; *.dat";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MyFName = openFileDialog.FileName;
                richTextBox.LoadFile(MyFName);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxLog.Clear();
            textBoxSecondWord.Clear();
            textBoxFirstWord.Clear();
            richTextBox.Clear();
            findFirstBtn.Enabled = true;
            findSecondBtn.Enabled = true;
            changeWordsBtn.Enabled = false;
            richTextBox.ReadOnly = false;
            endWordIndex = 0;
        }

        int result1, result2;


        private void findFirstBtn_Click(object sender, EventArgs e)
        {
            int LenText;
            textBoxLog.Text += "Поиск первого слова" + Environment.NewLine;
            String FWord = textBoxFirstWord.Text.ToString();
            LenText = richTextBox.Text.Length;
            this.result1 = FindWord(FWord, LenText);
            if (result1 != -1)
            {
                textBoxLog.Text += "Позиция первого слова: " + (result1 + 1) + Environment.NewLine + Environment.NewLine;
                richTextBox.SelectionStart = result1;
                richTextBox.SelectionLength = FWord.Length;
                richTextBox.SelectionBackColor = Color.Red;
                findFirstBtn.Enabled = false;
                if (findSecondBtn.Enabled == false)
                {
                    changeWordsBtn.Enabled = true;
                }
            }
            else
            {
                textBoxLog.Text += "Слово не найдено " + Environment.NewLine + Environment.NewLine;
            }
        }

        private void findSecondBtn_Click(object sender, EventArgs e)
        {
            int LenText;
            textBoxLog.Text += "Поиск второго слова" + Environment.NewLine;
            string FWord = textBoxSecondWord.Text.ToString();
            LenText = richTextBox.Text.Length;
            this.result2 = FindWord(FWord, LenText);
            if (result2 != -1)
            {
                textBoxLog.Text += "Позиция второго слова: " + (result2 + 1) + Environment.NewLine + Environment.NewLine;
                richTextBox.SelectionStart = result2;
                richTextBox.SelectionLength = FWord.Length;
                richTextBox.SelectionBackColor = Color.Green;
                findSecondBtn.Enabled = false;
                if (findFirstBtn.Enabled == false)
                {
                    changeWordsBtn.Enabled = true;
                }
            }
            else
            {
                textBoxLog.Text += "Слово не найдено " + Environment.NewLine + Environment.NewLine;
            }
        }

        private int FindWord(string FWord, int n)
        {
            int LenWord;
            string ComparText;
            LenWord = FWord.Length;
            for (int i = 0; i <= n - LenWord; i++)
            {
                ComparText = richTextBox.Text.Substring(i, LenWord);
                if (ComparText == FWord)
                {
                    return i;
                }
            }
            return -1;
        }

        private int endWordIndex = 0;

        // поиск слов начинающиихся на глассные
        private void selectVowelLettersBtn_Click(object sender, EventArgs e)
        {
            richTextBox.ReadOnly = true;
            string text = richTextBox.Text;

            string endRegex = @"[a-zа-яё]+";
            string russianLetters = "[аеёиоуыэюя]";
            string englishLetters = "[aeiou]";
            string startRegex = "(^|[^\\w])";
            string fullRegexString = startRegex + "(" + russianLetters + "|" + englishLetters + ")" + endRegex;
            Regex regex = new Regex(fullRegexString, RegexOptions.IgnoreCase);
            MatchCollection allMatches = regex.Matches(text);

            textBoxLog.Text += Environment.NewLine + "Всего слов найдено: " + allMatches.Count + Environment.NewLine + Environment.NewLine;

            text = text.Substring(endWordIndex);
            regex = new Regex(fullRegexString, RegexOptions.IgnoreCase);

            Match match = regex.Match(text);
            if (match.Success)
            {
                int findWordIndex = this.endWordIndex + match.Index;
                richTextBox.SelectionStart = findWordIndex;
                Regex lastSymbolRegex = new Regex(@"[^\w]$");
                int wordLength = match.Value.Length;
                if (lastSymbolRegex.IsMatch(match.Value))
                {
                    wordLength--;
                }

                this.endWordIndex = findWordIndex + wordLength;
                richTextBox.SelectionLength = wordLength;
                richTextBox.SelectionBackColor = Color.Pink;
            }
        }

        private void changeWordsBtn_Click(object sender, EventArgs e)
        {
            if (result1 < result2)
            {
                richTextBox.Select(result2, textBoxSecondWord.Text.Length);
                richTextBox.SelectedText = textBoxFirstWord.Text.ToString();
                richTextBox.Select(result1, textBoxFirstWord.Text.Length);
                richTextBox.SelectedText = textBoxSecondWord.Text.ToString();
                textBoxLog.Text += "Произошла замена слов";
                changeWordsBtn.Enabled = false;
            }
            else
            {
                richTextBox.Select(result1, textBoxFirstWord.Text.Length);
                richTextBox.SelectedText = textBoxSecondWord.Text.ToString();
                richTextBox.Select(result2, textBoxSecondWord.Text.Length);
                richTextBox.SelectedText = textBoxFirstWord.Text.ToString();
                textBoxLog.Text += "Произошла замена слов";
                changeWordsBtn.Enabled = false;
            }
        }
    }
}
