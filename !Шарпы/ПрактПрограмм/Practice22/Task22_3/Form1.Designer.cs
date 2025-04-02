namespace Task22_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumbers = new TextBox();
            label1 = new Label();
            lblResult = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(32, 50);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(220, 23);
            txtNumbers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(89, 16);
            label1.TabIndex = 1;
            label1.Text = "Введите числа:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(32, 167);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(95, 16);
            lblResult.TabIndex = 2;
            lblResult.Text = "Четных чисел: 0";
            // 
            // button1
            // 
            button1.Location = new Point(32, 100);
            button1.Name = "button1";
            button1.Size = new Size(220, 45);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 201);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(txtNumbers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumbers;
        private Label label1;
        private Label lblResult;
        private Button button1;
    }
}
