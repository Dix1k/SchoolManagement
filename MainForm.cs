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
            dataGridClasses.Rows.Clear();
            foreach (SchoolClass schoolClass in schoolClasses)
            {
                dataGridStudents.Rows.Add(schoolClass.ClassName, schoolClass.Subjects);
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();
            if (addTeacherForm.ShowDialog() == DialogResult.OK)
            {
                if (addTeacherForm.NewTeacher != null)
                {
                    teachers.Add(addTeacherForm.NewTeacher);
                    UpdateTeacherGrid();
                }
                else
                {
                    MessageBox.Show("Не удалось создать учителя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentForm();
            if (addStudentForm.ShowDialog() == DialogResult.OK)
            {
                students.Add(addStudentForm.NewStudent);
                UpdateStudentGrid();
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            var addClassesForm = new AddClassesForm();
            if (addClassesForm.ShowDialog() == DialogResult.OK)
            {
                schoolClasses.Add(addClassesForm.NewClasses);
                UpdateClassesGrid();
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (dataGridTeachers.SelectedRows.Count > 0)
            {
                // Запрашиваем подтверждение удаления
                var result = MessageBox.Show("Вы уверены, что хотите удалить этого учителя?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Получаем индекс выделенной строки
                    int selectedIndex = dataGridTeachers.SelectedRows[0].Index;

                    // Удаляем учителя из списка по индексу
                    teachers.RemoveAt(selectedIndex);
                    UpdateTeacherGrid();
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
                // Запрашиваем подтверждение удаления
                var result = MessageBox.Show("Вы уверены, что хотите удалить этого студента?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Получаем индекс выделенной строки
                    int selectedIndex = dataGridStudents.SelectedRows[0].Index;

                    // Удаляем студента из списка по индексу
                    students.RemoveAt(selectedIndex);
                    UpdateStudentGrid();
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
                var result = MessageBox.Show("Вы уверены, что хотите удалить этого студента?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Получаем индекс выделенной строки
                    int selectedIndex = dataGridClasses.SelectedRows[0].Index;

                    // Удаляем студента из списка по индексу
                    schoolClasses.RemoveAt(selectedIndex);
                    UpdateClassesGrid();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите класс для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            UpdateClassesGrid();
            MessageBox.Show("Данные успешно обновлениы!", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
