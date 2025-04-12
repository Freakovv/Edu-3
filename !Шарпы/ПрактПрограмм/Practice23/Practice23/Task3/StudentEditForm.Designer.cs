using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Practice23.Task3
{
    partial class StudentEditForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEditForm));
            labelFullName = new Label();
            txtFullName = new TextBox();
            labelGroupNumber = new Label();
            txtGroupNumber = new TextBox();
            labelGrades = new Label();
            txtGrade1 = new TextBox();
            txtGrade2 = new TextBox();
            txtGrade3 = new TextBox();
            txtGrade4 = new TextBox();
            txtGrade5 = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new System.Drawing.Point(14, 16);
            labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new System.Drawing.Size(37, 16);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "ФИО";
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(14, 36);
            txtFullName.Margin = new System.Windows.Forms.Padding(4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(333, 23);
            txtFullName.TabIndex = 1;
            // 
            // labelGroupNumber
            // 
            labelGroupNumber.AutoSize = true;
            labelGroupNumber.Location = new System.Drawing.Point(14, 71);
            labelGroupNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelGroupNumber.Name = "labelGroupNumber";
            labelGroupNumber.Size = new System.Drawing.Size(51, 16);
            labelGroupNumber.TabIndex = 2;
            labelGroupNumber.Text = "Группа";
            // 
            // txtGroupNumber
            // 
            txtGroupNumber.Location = new System.Drawing.Point(14, 91);
            txtGroupNumber.Margin = new System.Windows.Forms.Padding(4);
            txtGroupNumber.Name = "txtGroupNumber";
            txtGroupNumber.Size = new System.Drawing.Size(333, 23);
            txtGroupNumber.TabIndex = 2;
            // 
            // labelGrades
            // 
            labelGrades.AutoSize = true;
            labelGrades.Location = new System.Drawing.Point(14, 126);
            labelGrades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelGrades.Name = "labelGrades";
            labelGrades.Size = new System.Drawing.Size(58, 16);
            labelGrades.TabIndex = 4;
            labelGrades.Text = "Оценки";
            // 
            // txtGrade1
            // 
            txtGrade1.Location = new System.Drawing.Point(14, 146);
            txtGrade1.Margin = new System.Windows.Forms.Padding(4);
            txtGrade1.MaxLength = 1;
            txtGrade1.Name = "txtGrade1";
            txtGrade1.Size = new System.Drawing.Size(50, 23);
            txtGrade1.TabIndex = 3;
            txtGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrade2
            // 
            txtGrade2.Location = new System.Drawing.Point(72, 146);
            txtGrade2.Margin = new System.Windows.Forms.Padding(4);
            txtGrade2.MaxLength = 1;
            txtGrade2.Name = "txtGrade2";
            txtGrade2.Size = new System.Drawing.Size(50, 23);
            txtGrade2.TabIndex = 4;
            txtGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrade3
            // 
            txtGrade3.Location = new System.Drawing.Point(130, 146);
            txtGrade3.Margin = new System.Windows.Forms.Padding(4);
            txtGrade3.MaxLength = 1;
            txtGrade3.Name = "txtGrade3";
            txtGrade3.Size = new System.Drawing.Size(50, 23);
            txtGrade3.TabIndex = 5;
            txtGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrade4
            // 
            txtGrade4.Location = new System.Drawing.Point(188, 146);
            txtGrade4.Margin = new System.Windows.Forms.Padding(4);
            txtGrade4.MaxLength = 1;
            txtGrade4.Name = "txtGrade4";
            txtGrade4.Size = new System.Drawing.Size(50, 23);
            txtGrade4.TabIndex = 6;
            txtGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrade5
            // 
            txtGrade5.Location = new System.Drawing.Point(246, 146);
            txtGrade5.Margin = new System.Windows.Forms.Padding(4);
            txtGrade5.MaxLength = 1;
            txtGrade5.Name = "txtGrade5";
            txtGrade5.Size = new System.Drawing.Size(50, 23);
            txtGrade5.TabIndex = 7;
            txtGrade5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.Image = (System.Drawing.Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSave.Location = new System.Drawing.Point(14, 186);
            btnSave.Margin = new System.Windows.Forms.Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(160, 37);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(187, 186);
            btnCancel.Margin = new System.Windows.Forms.Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(160, 37);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // StudentEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(363, 238);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtGrade5);
            Controls.Add(txtGrade4);
            Controls.Add(txtGrade3);
            Controls.Add(txtGrade2);
            Controls.Add(txtGrade1);
            Controls.Add(labelGrades);
            Controls.Add(txtGroupNumber);
            Controls.Add(labelGroupNumber);
            Controls.Add(txtFullName);
            Controls.Add(labelFullName);
            Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Редактирование студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelGroupNumber;
        private System.Windows.Forms.TextBox txtGroupNumber;
        private System.Windows.Forms.Label labelGrades;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.TextBox txtGrade2;
        private System.Windows.Forms.TextBox txtGrade3;
        private System.Windows.Forms.TextBox txtGrade4;
        private System.Windows.Forms.TextBox txtGrade5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}