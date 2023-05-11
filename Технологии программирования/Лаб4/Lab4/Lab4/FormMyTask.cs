using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lab4
{
    public partial class FormMyTask : Form
    {
        public FormMyTask()
        {
            InitializeComponent();

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 4;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 4;
            numericUpDowAvgMark.Controls[0].Visible = false;
            numericUpDownAvgMarkForFilter.Controls[0].Visible = false;
        }

        private List<Student> students = new List<Student>();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.fio = textBoxFio.Text;
            student.group = textBoxGroup.Text;
            student.avgMark = Convert.ToDouble(numericUpDowAvgMark.Value);
            student.schoolarship = Convert.ToDouble(numericUpDownSchoolarship.Value); ;
            students.Add(student);
            dataGridView1.Rows.Add(student.fio, student.group, student.avgMark, student.schoolarship);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            double avgMarkForFilter = Convert.ToDouble(numericUpDownAvgMarkForFilter.Value);

            List<Student> studentsFilter = this.students.FindAll(s => s.avgMark > avgMarkForFilter);
            foreach (Student student in studentsFilter)
            {
                dataGridView2.Rows.Add(student.fio, student.group, student.avgMark, student.schoolarship);
            }

            var direction = ListSortDirection.Descending;
            dataGridView2.Sort(avgMarkColumn2, direction);
        }
    }
}
