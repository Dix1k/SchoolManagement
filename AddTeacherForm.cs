using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class AddTeacherForm : Form
    {
        public Teacher NewTeacher { get; private set; }

        public AddTeacherForm(DataGridView dataGridClasses)
        {
            InitializeComponent();
            LoadSubjects(dataGridClasses);
        }

        private void LoadSubjects(DataGridView dataGridClasses)
        {
            var subjects = new HashSet<string>();

            foreach (DataGridViewRow row in dataGridClasses.Rows)
            {
                if (row.Cells["Subjects"].Value != null)
                {
                    var subjectList = row.Cells["Subjects"].Value.ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var subject in subjectList)
                    {
                        subjects.Add(subject.Trim());
                    }
                }
            }

            // Заполнение списка предметов
            lstSubjects.Items.AddRange(subjects.ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string roomNumber = numRoomNumber.Text;

            // Получение выбранных предметов
            List<string> subjects = lstSubjects.SelectedItems.Cast<string>().ToList();

            if (string.IsNullOrEmpty(fullName) || subjects.Count == 0)
            {
                MessageBox.Show("Заполните все поля и выберите хотя бы один предмет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание объекта Teacher
            NewTeacher = new Teacher(fullName, subjects, roomNumber);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            // Удалите этот метод, если больше не нужно добавлять предметы вручную
            MessageBox.Show("Выберите предметы из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
