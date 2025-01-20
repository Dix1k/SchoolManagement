namespace SchoolManagement
{
    partial class AddTeacherForm
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
            txtFullName = new TextBox();
            txtNewSubject = new TextBox();
            btnSave = new Button();
            btnAddSubject = new Button();
            lstSubjects = new ListBox();
            numRoomNumber = new TextBox();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(10, 10);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "ФИО учителя";
            txtFullName.Size = new Size(200, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtNewSubject
            // 
            txtNewSubject.Location = new Point(228, 10);
            txtNewSubject.Name = "txtNewSubject";
            txtNewSubject.PlaceholderText = "Предмет";
            txtNewSubject.Size = new Size(112, 23);
            txtNewSubject.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(353, 134);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(346, 10);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(75, 23);
            btnAddSubject.TabIndex = 5;
            btnAddSubject.Text = "Добавить";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // lstSubjects
            // 
            lstSubjects.FormattingEnabled = true;
            lstSubjects.ItemHeight = 15;
            lstSubjects.Location = new Point(10, 39);
            lstSubjects.Name = "lstSubjects";
            lstSubjects.Size = new Size(200, 109);
            lstSubjects.TabIndex = 6;
            // 
            // numRoomNumber
            // 
            numRoomNumber.Location = new Point(228, 50);
            numRoomNumber.Name = "numRoomNumber";
            numRoomNumber.PlaceholderText = "Номер кабинета";
            numRoomNumber.Size = new Size(100, 23);
            numRoomNumber.TabIndex = 7;
            // 
            // AddTeacherForm
            // 
            ClientSize = new Size(433, 164);
            Controls.Add(numRoomNumber);
            Controls.Add(lstSubjects);
            Controls.Add(btnAddSubject);
            Controls.Add(txtFullName);
            Controls.Add(txtNewSubject);
            Controls.Add(btnSave);
            Name = "AddTeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить учителя";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNewSubject;
        private System.Windows.Forms.Button btnSave;
        private Button btnAddSubject;
        private ListBox lstSubjects;
        private TextBox numRoomNumber;
    }
}