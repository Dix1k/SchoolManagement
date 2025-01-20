namespace SchoolManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabTeachers = new TabPage();
            dataGridTeachers = new DataGridView();
            Id_teachers = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Subjects = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            tabStudents = new TabPage();
            dataGridStudents = new DataGridView();
            Id_students = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            ClassName = new DataGridViewTextBoxColumn();
            Grades = new DataGridViewTextBoxColumn();
            tabClasses = new TabPage();
            dataGridClasses = new DataGridView();
            Class = new DataGridViewTextBoxColumn();
            Subjects_class = new DataGridViewTextBoxColumn();
            btnAddTeacher = new Button();
            btnDeleteTeacher = new Button();
            btnAddStudent = new Button();
            btnDeleteStudent = new Button();
            btnSaveData = new Button();
            btnLoadData = new Button();
            btnSetRatings = new Button();
            btnRequest1 = new Button();
            comboBoxSubjects = new ComboBox();
            btnAddClass = new Button();
            btnDeleteClass = new Button();
            tabControl.SuspendLayout();
            tabTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTeachers).BeginInit();
            tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).BeginInit();
            tabClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClasses).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabTeachers);
            tabControl.Controls.Add(tabStudents);
            tabControl.Controls.Add(tabClasses);
            tabControl.Dock = DockStyle.Top;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(861, 400);
            tabControl.TabIndex = 0;
            // 
            // tabTeachers
            // 
            tabTeachers.Controls.Add(dataGridTeachers);
            tabTeachers.Location = new Point(4, 24);
            tabTeachers.Name = "tabTeachers";
            tabTeachers.Size = new Size(853, 372);
            tabTeachers.TabIndex = 0;
            tabTeachers.Text = "Учителя";
            // 
            // dataGridTeachers
            // 
            dataGridTeachers.AllowUserToAddRows = false;
            dataGridTeachers.AllowUserToDeleteRows = false;
            dataGridTeachers.AllowUserToResizeColumns = false;
            dataGridTeachers.AllowUserToResizeRows = false;
            dataGridTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridTeachers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridTeachers.Columns.AddRange(new DataGridViewColumn[] { Id_teachers, FullName, Subjects, RoomNumber });
            dataGridTeachers.Dock = DockStyle.Fill;
            dataGridTeachers.EnableHeadersVisualStyles = false;
            dataGridTeachers.Location = new Point(0, 0);
            dataGridTeachers.Name = "dataGridTeachers";
            dataGridTeachers.ReadOnly = true;
            dataGridTeachers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTeachers.Size = new Size(853, 372);
            dataGridTeachers.TabIndex = 0;
            // 
            // Id_teachers
            // 
            Id_teachers.HeaderText = "id";
            Id_teachers.Name = "Id_teachers";
            Id_teachers.ReadOnly = true;
            Id_teachers.Width = 42;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 86;
            // 
            // Subjects
            // 
            Subjects.HeaderText = "Subjects";
            Subjects.Name = "Subjects";
            Subjects.ReadOnly = true;
            Subjects.Width = 76;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            RoomNumber.Width = 111;
            // 
            // tabStudents
            // 
            tabStudents.Controls.Add(dataGridStudents);
            tabStudents.Location = new Point(4, 24);
            tabStudents.Name = "tabStudents";
            tabStudents.Size = new Size(853, 372);
            tabStudents.TabIndex = 1;
            tabStudents.Text = "Ученики";
            // 
            // dataGridStudents
            // 
            dataGridStudents.AllowUserToAddRows = false;
            dataGridStudents.AllowUserToDeleteRows = false;
            dataGridStudents.AllowUserToResizeColumns = false;
            dataGridStudents.AllowUserToResizeRows = false;
            dataGridStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridStudents.Columns.AddRange(new DataGridViewColumn[] { Id_students, FirstName, LastName, ClassName, Grades });
            dataGridStudents.Dock = DockStyle.Fill;
            dataGridStudents.EnableHeadersVisualStyles = false;
            dataGridStudents.Location = new Point(0, 0);
            dataGridStudents.Name = "dataGridStudents";
            dataGridStudents.ReadOnly = true;
            dataGridStudents.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridStudents.Size = new Size(853, 372);
            dataGridStudents.TabIndex = 0;
            // 
            // Id_students
            // 
            Id_students.HeaderText = "id";
            Id_students.Name = "Id_students";
            Id_students.ReadOnly = true;
            Id_students.Width = 42;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 89;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 88;
            // 
            // ClassName
            // 
            ClassName.HeaderText = "Class";
            ClassName.Name = "ClassName";
            ClassName.ReadOnly = true;
            ClassName.Width = 59;
            // 
            // Grades
            // 
            Grades.HeaderText = "Grades";
            Grades.Name = "Grades";
            Grades.ReadOnly = true;
            Grades.Width = 68;
            // 
            // tabClasses
            // 
            tabClasses.Controls.Add(dataGridClasses);
            tabClasses.Location = new Point(4, 24);
            tabClasses.Name = "tabClasses";
            tabClasses.Size = new Size(853, 372);
            tabClasses.TabIndex = 2;
            tabClasses.Text = "Классы";
            tabClasses.UseVisualStyleBackColor = true;
            // 
            // dataGridClasses
            // 
            dataGridClasses.AllowUserToAddRows = false;
            dataGridClasses.AllowUserToDeleteRows = false;
            dataGridClasses.AllowUserToResizeColumns = false;
            dataGridClasses.AllowUserToResizeRows = false;
            dataGridClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridClasses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridClasses.Columns.AddRange(new DataGridViewColumn[] { Class, Subjects_class });
            dataGridClasses.Dock = DockStyle.Fill;
            dataGridClasses.Location = new Point(0, 0);
            dataGridClasses.Name = "dataGridClasses";
            dataGridClasses.ReadOnly = true;
            dataGridClasses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClasses.Size = new Size(853, 372);
            dataGridClasses.TabIndex = 0;
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.Name = "Class";
            Class.ReadOnly = true;
            Class.Width = 59;
            // 
            // Subjects_class
            // 
            Subjects_class.HeaderText = "Subjects";
            Subjects_class.Name = "Subjects_class";
            Subjects_class.ReadOnly = true;
            Subjects_class.Width = 76;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(10, 410);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(134, 23);
            btnAddTeacher.TabIndex = 1;
            btnAddTeacher.Text = "Добавить учителя";
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // btnDeleteTeacher
            // 
            btnDeleteTeacher.Location = new Point(150, 410);
            btnDeleteTeacher.Name = "btnDeleteTeacher";
            btnDeleteTeacher.Size = new Size(114, 23);
            btnDeleteTeacher.TabIndex = 2;
            btnDeleteTeacher.Text = "Удалить учителя";
            btnDeleteTeacher.Click += btnDeleteTeacher_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(10, 439);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(134, 23);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Добавить ученика";
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(150, 439);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(114, 23);
            btnDeleteStudent.TabIndex = 4;
            btnDeleteStudent.Text = "Удалить ученика";
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnSaveData
            // 
            btnSaveData.Location = new Point(550, 410);
            btnSaveData.Name = "btnSaveData";
            btnSaveData.Size = new Size(125, 23);
            btnSaveData.TabIndex = 5;
            btnSaveData.Text = "Сохранить данные";
            btnSaveData.Click += btnSaveData_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(550, 439);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(125, 23);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Обновить данные";
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnSetRatings
            // 
            btnSetRatings.Location = new Point(10, 497);
            btnSetRatings.Name = "btnSetRatings";
            btnSetRatings.Size = new Size(254, 23);
            btnSetRatings.TabIndex = 7;
            btnSetRatings.Text = "Установить оценки выбранному ученику";
            btnSetRatings.UseVisualStyleBackColor = true;
            btnSetRatings.Click += btnSetRatings_Click;
            // 
            // btnRequest1
            // 
            btnRequest1.Location = new Point(372, 533);
            btnRequest1.Name = "btnRequest1";
            btnRequest1.Size = new Size(252, 23);
            btnRequest1.TabIndex = 8;
            btnRequest1.Text = "Успеваемость по заданному предмету";
            btnRequest1.UseVisualStyleBackColor = true;
            btnRequest1.Click += btnRequest1_Click;
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.Location = new Point(630, 533);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new Size(121, 23);
            comboBoxSubjects.TabIndex = 9;
            // 
            // btnAddClass
            // 
            btnAddClass.Location = new Point(10, 468);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(134, 23);
            btnAddClass.TabIndex = 10;
            btnAddClass.Text = "Добавить класс";
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.Location = new Point(150, 468);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new Size(114, 23);
            btnDeleteClass.TabIndex = 11;
            btnDeleteClass.Text = "Удалить класс";
            btnDeleteClass.UseVisualStyleBackColor = true;
            btnDeleteClass.Click += btnDeleteClass_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(861, 711);
            Controls.Add(btnDeleteClass);
            Controls.Add(btnAddClass);
            Controls.Add(comboBoxSubjects);
            Controls.Add(btnRequest1);
            Controls.Add(btnSetRatings);
            Controls.Add(tabControl);
            Controls.Add(btnAddTeacher);
            Controls.Add(btnDeleteTeacher);
            Controls.Add(btnAddStudent);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnSaveData);
            Controls.Add(btnLoadData);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Школьная система управления";
            WindowState = FormWindowState.Maximized;
            tabControl.ResumeLayout(false);
            tabTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridTeachers).EndInit();
            tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).EndInit();
            tabClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridClasses).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTeachers;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.DataGridView dataGridTeachers;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
        private DataGridViewTextBoxColumn Id_teachers;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Subjects;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn Id_students;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn ClassName;
        private DataGridViewTextBoxColumn Grades;
        private Button btnSetRatings;
        private Button btnRequest1;
        private ComboBox comboBoxSubjects;
        private TabPage tabClasses;
        private DataGridView dataGridClasses;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Subjects_class;
        private Button btnAddClass;
        private Button btnDeleteClass;
    }
}
