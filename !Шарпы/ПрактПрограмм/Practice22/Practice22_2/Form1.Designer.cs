namespace Practice22_2
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
            textBoxB = new TextBox();
            label2 = new Label();
            textBoxX = new TextBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBoxResult = new RichTextBox();
            buttonCalculate = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(46, 75);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(245, 23);
            textBoxB.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 78);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 6;
            label2.Text = "B:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(46, 26);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(245, 23);
            textBoxX.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 4;
            label1.Text = "X:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(319, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "sh(x)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(319, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 24);
            radioButton2.TabIndex = 9;
            radioButton2.Text = "x^2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(319, 82);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(48, 24);
            radioButton3.TabIndex = 10;
            radioButton3.Text = "e^x";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(19, 132);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(411, 154);
            textBoxResult.TabIndex = 11;
            textBoxResult.Text = "";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(19, 292);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(210, 40);
            buttonCalculate.TabIndex = 12;
            buttonCalculate.Text = "Start";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 292);
            button2.Name = "button2";
            button2.Size = new Size(203, 40);
            button2.TabIndex = 13;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 344);
            Controls.Add(button2);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxResult);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBoxB);
            Controls.Add(label2);
            Controls.Add(textBoxX);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxB;
        private Label label2;
        private TextBox textBoxX;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RichTextBox textBoxResult;
        private Button buttonCalculate;
        private Button button2;
    }
}
