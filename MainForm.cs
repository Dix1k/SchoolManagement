using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class MainForm : Form
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private List<SchoolClass> schoolClasses;

        public MainForm()
        {
            InitializeComponent();
            teachers = new List<Teacher>();
            students = new List<Student>();
            schoolClasses = new List<SchoolClass>();

            LoadData(); // Загрузка данных при загрузке формы
            UpdateTeacherGrid();
            UpdateStudentGrid();
            UpdateClassesGrid();
        }

        private void LoadData()
        {
            teachers = Serializer.DeserializeFromFile<List<Teacher>>("teachers.json") ?? new List<Teacher>();
            students = Serializer.DeserializeFromFile<List<Student>>("students.json") ?? new List<Student>();
            schoolClasses = Serializer.DeserializeFromFile<List<SchoolClass>>("schoolClass.json") ?? new List<SchoolClass>();
        }

        private void UpdateTeacherGrid()
        {
            dataGridTeachers.Rows.Clear();

            foreach (Teacher teacher in teachers)
            {
                if (teacher != null)
                {
                    string subjects = string.Join(", ", teacher.Subjects);
                    dataGridTeachers.Rows.Add(teacher.Id, teacher.FullName, subjects, teacher.RoomNumber);
                }
            }
        }

        private void UpdateStudentGrid()
        {
            dataGridStudents.Rows.Clear();

            foreach (Student student in students)
            {
                string gradesFormatted = string.Join(", ", student.Grades.Select(g => $"{g.Key}: {g.Value}"));
                dataGridStudents.Rows.Add(student.Id, student.FirstName, student.LastName, student.ClassName, gradesFormatted);
            }
        }
        private void UpdateClassesGrid()
        {
            dataGridClasses.Rows.Clear(); // Очистка текущих данных в гриде классов
            foreach (SchoolClass schoolClass in schoolClasses)
            {
                if (schoolClass != null)
                {
                    string subjects = string.Join(", ", schoolClass.Subjects);
                    dataGridClasses.Rows.Add(schoolClass.ClassName, subjects);
                }
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm(dataGridClasses);
            if (addTeacherForm.ShowDialog() == DialogResult.OK)
            {
                if (addTeacherForm.NewTeacher != null)
                {
                    teachers.Add(addTeacherForm.NewTeacher);
                    UpdateTeacherGrid();
                    btnSaveData_Click(sender, e); // Сохранение данных после добавления
                }
                else
                {
                    MessageBox.Show("Не удалось создать учителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Предположим, что у вас есть DataGridView с классами
            List<string> classes = new List<string>();

            foreach (DataGridViewRow row in dataGridClasses.Rows)
            {
                if (row.Cells["ClassName"].Value != null)
                {
                    classes.Add(row.Cells["ClassName"].Value.ToString());
                }
            }

            using (AddStudentForm addStudentForm = new AddStudentForm(classes))
            {
                if (addStudentForm.ShowDialog() == DialogResult.OK)
                {
                    students.Add(addStudentForm.NewStudent);
                    UpdateStudentGrid();
                    btnSaveData_Click(sender, e); // Сохранение данных после добавления
                }
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddClassesForm addClassesForm = new AddClassesForm();
            if (addClassesForm.ShowDialog() == DialogResult.OK)
            {
                schoolClasses.Add(addClassesForm.NewClasses);
                UpdateClassesGrid();
                btnSaveData_Click(sender, e); // Сохранение данных после добавления
            }
        }




        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (dataGridTeachers.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить этого учителя?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridTeachers.SelectedRows[0].Index;

                    if (selectedIndex >= 0 && selectedIndex < teachers.Count)
                    {
                        teachers.RemoveAt(selectedIndex);
                        UpdateTeacherGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: выбранный индекс недействителен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите учителя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridStudents.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить этого студента?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridStudents.SelectedRows[0].Index;

                    if (selectedIndex >= 0 && selectedIndex < students.Count)
                    {
                        students.RemoveAt(selectedIndex);
                        UpdateStudentGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: выбранный индекс недействителен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dataGridClasses.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить этот класс?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = dataGridClasses.SelectedRows[0].Index;

                    if (selectedIndex >= 0 && selectedIndex < schoolClasses.Count)
                    {
                        schoolClasses.RemoveAt(selectedIndex);
                        UpdateClassesGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: выбранный индекс недействителен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите класс для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnSaveData_Click(object sender, EventArgs e)
        {
            Serializer.SerializeToFile("teachers.json", teachers);
            Serializer.SerializeToFile("students.json", students);
            Serializer.SerializeToFile("schoolClass.json", schoolClasses);
            MessageBox.Show("Данные успешно сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData(); // Вызов метода загрузки данных
            UpdateTeacherGrid();
            UpdateStudentGrid();
            UpdateClassesGrid(); // Обновление грида классов
            MessageBox.Show("Данные успешно обновлены!", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSetRatings_Click(object sender, EventArgs e)
        {
            if (dataGridStudents.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridStudents.SelectedRows[0].Index;
                Student selectedStudent = students[selectedIndex];

                SetRatingsForm setRatingsForm = new SetRatingsForm();
                if (setRatingsForm.ShowDialog() == DialogResult.OK)
                {
                    // Обновляем оценки ученика
                    selectedStudent.Grades = setRatingsForm.Ratings;
                    UpdateStudentGrid();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите ученика для установки оценок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRequest1_Click(object sender, EventArgs e)
        {

        }
    }
}
