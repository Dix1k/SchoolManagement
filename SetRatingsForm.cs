using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class SetRatingsForm : Form
    {
        public Dictionary<string, int> Ratings { get; private set; }

        public SetRatingsForm()
        {
            InitializeComponent();
            Ratings = new Dictionary<string, int>();
        }
        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text.Trim();
            if (!string.IsNullOrEmpty(subject) && !Ratings.ContainsKey(subject))
            {
                Ratings[subject] = 0; // Инициализируем значение
                UpdateSubjectList();
                txtSubject.Clear();
            }
            else
            {
                MessageBox.Show("Введите корректное название предмета или предмет уже добавлен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSubjectList()
        {
            flowLayoutPanel.Controls.Clear();
            foreach (var subject in Ratings.Keys)
            {
                var label = new Label { Text = subject };
                var textBox = new TextBox { Name = subject, Width = 50 };

                flowLayoutPanel.Controls.Add(label);
                flowLayoutPanel.Controls.Add(textBox);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var subject in Ratings.Keys)
            {
                var textBox = flowLayoutPanel.Controls[subject] as TextBox;
                if (textBox != null && int.TryParse(textBox.Text, out int grade))
                {
                    Ratings[subject] = grade;
                }
                else
                {
                    MessageBox.Show($"Некорректная оценка для {subject}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}