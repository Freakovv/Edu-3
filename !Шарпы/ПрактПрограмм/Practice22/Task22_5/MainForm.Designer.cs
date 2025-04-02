namespace Task22_5
{
    partial class MainForm
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
            this.txtOriginalArray = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnFillArray = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtOriginalArray
            this.txtOriginalArray.Location = new System.Drawing.Point(12, 32);
            this.txtOriginalArray.Multiline = true;
            this.txtOriginalArray.Name = "txtOriginalArray";
            this.txtOriginalArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginalArray.Size = new System.Drawing.Size(200, 200);
            this.txtOriginalArray.TabIndex = 0;

            // txtResult
            this.txtResult.Location = new System.Drawing.Point(218, 32);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(200, 200);
            this.txtResult.TabIndex = 1;

            // btnFillArray
            this.btnFillArray.Location = new System.Drawing.Point(12, 238);
            this.btnFillArray.Name = "btnFillArray";
            this.btnFillArray.Size = new System.Drawing.Size(200, 30);
            this.btnFillArray.TabIndex = 2;
            this.btnFillArray.Text = "Заполнить массив";
            this.btnFillArray.UseVisualStyleBackColor = true;
            this.btnFillArray.Click += new System.EventHandler(this.btnFillArray_Click);

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(218, 238);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 30);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Вычислить произведение";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходный массив";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnFillArray);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOriginalArray);
            this.Name = "MainForm";
            this.Text = "Обработка массива";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtOriginalArray;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnFillArray;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}
