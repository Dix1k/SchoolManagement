using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string roomNumber = numRoomNumber.Text;
            List<string> subjects = lstSubjects.Items.Cast<string>().ToList();

            if (string.IsNullOrEmpty(fullName) || subjects.Count == 0)
            {
                MessageBox.Show("Заполните все поля и добавьте хотя бы один предмет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание объекта Teacher
            NewTeacher = new Teacher(fullName, subjects, roomNumber);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string newSubject = txtNewSubject.Text.Trim();
            if (!string.IsNullOrEmpty(newSubject) && !lstSubjects.Items.Contains(newSubject))
            {
                lstSubjects.Items.Add(newSubject);
                txtNewSubject.Clear();
            }
            else
            {
                MessageBox.Show("Введите уникальный предмет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
