using System;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxPost.Items.Add("Преподаватель");
            comboBoxPost.Items.Add("Ст. преподаватель");
            comboBoxPost.Items.Add("Доцент");
            comboBoxPost.Items.Add("Профессор");

            comboBoxAcademicDegree.Items.AddRange(new object[] { "Без уч. степени", "Кандидатнаук", "Доктор наук" });

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 5;
            //dataGridView1.Columns[0].HeaderText = "ФИО";
            //dataGridView1.Columns[1].HeaderText = "Должность";
            //dataGridView1.Columns[2].HeaderText = "Дата рождения";
            //dataGridView1.Columns[3].HeaderText = "Ученая степень";
            //dataGridView1.Columns[4].HeaderText = "Стаж";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 5;
            //dataGridView2.Columns[0].HeaderText = "ФИО";
            //dataGridView2.Columns[1].HeaderText = "Должность";
            //dataGridView2.Columns[2].HeaderText = "Дата рождения";
            //dataGridView2.Columns[3].HeaderText = "Ученая степень";
            //dataGridView2.Columns[4].HeaderText = "Стаж";
            dataGridView2.RowHeadersVisible = false;

        }

        Employee[] worker = new Employee[10];
        int count = 0;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            worker[count].FIO = textBoxFio.Text;
            worker[count].Post = comboBoxPost.Text;
            worker[count].Date_of_Birth = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            worker[count].Degree = comboBoxAcademicDegree.Text;
            worker[count].Experience = Convert.ToInt32(numericUpDownExperience.Text);
            dataGridView1.Rows.Add(worker[count].FIO, worker[count].Post,
            worker[count].Date_of_Birth, worker[count].Degree,
            worker[count].Experience.ToString());
            count++;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (radioButtonExpirienceNotMin.Checked == true)
            {
                dataGridView2.Rows.Clear();
                int select1 = Convert.ToInt32(textBox1.Text);
                foreach (Employee wSel in worker)
                {
                    if (wSel.Experience >= select1)
                    {
                        dataGridView2.Rows.Add(wSel.FIO,
                            wSel.Post,
                            wSel.Date_of_Birth,
                            wSel.Degree,
                            wSel.Experience.ToString()
                        );
                    }
                }
            }

            if (radioButtonPost.Checked == true)
            {
                dataGridView2.Rows.Clear();
                string select2 = textBox1.Text;
                foreach (Employee wSel in worker)
                {
                    if (wSel.Post.ToLower() == select2.ToLower())
                    {
                        dataGridView2.Rows.Add(
                            wSel.FIO,
                            wSel.Post,
                            wSel.Date_of_Birth,
                            wSel.Degree,
                            wSel.Experience.ToString()
                        );
                    }

                }
            }
        }

        private void addDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAdd_Click(sender, e);
        }

        private void startQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonFind_Click(sender, e);
        }

        private void taskOfVariantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMyTask form = new FormMyTask();
            form.ShowDialog();
        }
    }
}
