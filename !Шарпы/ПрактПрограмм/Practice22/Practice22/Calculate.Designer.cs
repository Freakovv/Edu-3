namespace Practice22
{
    partial class Calculate
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 0;
            label1.Text = "X:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "16,55";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(39, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "-2,75";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 2;
            label2.Text = "Y:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(39, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 5;
            textBox3.Text = "0,15";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 4;
            label3.Text = "Z:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(92, 174);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 8;
            label5.Text = "Результат:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(10, 196);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(274, 23);
            textBox5.TabIndex = 9;
            textBox5.Text = "0";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(216, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 22);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "× 10⁻³";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Calculate
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 253);
            Controls.Add(checkBox1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Calculate";
            Text = "Calculate";
            Load += Calculate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label5;
        private TextBox textBox5;
        private CheckBox checkBox1;
    }
}