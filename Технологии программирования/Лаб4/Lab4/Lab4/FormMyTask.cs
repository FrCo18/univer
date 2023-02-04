using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        }

        private List<Student> students = new List<Student>();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.fio = textBoxFio.Text;
            student.dateOfBithday = dateTimePickerBithday.Value;
            student.phone = numericUpDownPhone.Value.ToString();
            student.address = textBoxAddress.Text;
            students.Add(student);
            dataGridView1.Rows.Add(student.fio, student.dateOfBithday.ToString("dd.MM.yyyy"), student.address, student.phone);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            List<Student> dublicateStudentsByDate = new List<Student>();
            foreach (Student student in this.students)
            {
                dublicateStudentsByDate.Add((Student)student.Clone());
            }

            foreach (Student student in this.students)
            {
                if (this.students.FindAll(s => s.dateOfBithday == student.dateOfBithday).Count == 1)
                {
                    dublicateStudentsByDate.Remove(student);
                }
            }

            foreach (Student student in dublicateStudentsByDate)
            {
                dataGridView2.Rows.Add(student.fio, student.dateOfBithday.ToString("dd.MM.yyyy"), student.address, student.phone);
            }

            var direction = ListSortDirection.Ascending;
            dataGridView2.Sort(dateOfBithColumn2, direction);
        }
    }
}
