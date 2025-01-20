namespace SchoolManagement
{
    partial class SetRatingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddSubject = new Button();
            btnSave = new Button();
            txtSubject = new TextBox();
            flowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(395, 11);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(124, 23);
            btnAddSubject.TabIndex = 0;
            btnAddSubject.Text = "Добавить предмет";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(395, 40);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(240, 12);
            txtSubject.Name = "txtSubject";
            txtSubject.PlaceholderText = "Введи название предмета";
            txtSubject.Size = new Size(149, 23);
            txtSubject.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Location = new Point(12, 12);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(222, 241);
            flowLayoutPanel.TabIndex = 3;
            // 
            // SetRatingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 289);
            Controls.Add(flowLayoutPanel);
            Controls.Add(txtSubject);
            Controls.Add(btnSave);
            Controls.Add(btnAddSubject);
            Name = "SetRatingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SetRatingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddSubject;
        private Button btnSave;
        private TextBox txtSubject;
        private FlowLayoutPanel flowLayoutPanel;
    }
}