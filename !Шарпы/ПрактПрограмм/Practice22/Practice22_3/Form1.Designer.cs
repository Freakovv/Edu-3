namespace Practice22_3
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
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            txtResults = new RichTextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 11;
            textBox3.Text = "0,4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 110);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 10;
            label3.Text = "dx:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 9;
            textBox2.Text = "19,1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 64);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 8;
            label2.Text = "Xk:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "13,7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 6;
            label1.Text = "X0:";
            // 
            // button1
            // 
            button1.Location = new Point(40, 519);
            button1.Name = "button1";
            button1.Size = new Size(245, 40);
            button1.TabIndex = 12;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(13, 184);
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(306, 329);
            txtResults.TabIndex = 13;
            txtResults.Text = "";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(40, 151);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 23);
            textBox4.TabIndex = 15;
            textBox4.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 154);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 14;
            label4.Text = "b:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 571);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(txtResults);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private RichTextBox txtResults;
        private TextBox textBox4;
        private Label label4;
    }
}
