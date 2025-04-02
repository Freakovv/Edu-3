namespace Task22_6
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
            label2 = new Label();
            dataGridView3x4 = new DataGridView();
            btnFill3x4 = new Button();
            btnFindMinRows = new Button();
            txtResult3x4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView3x4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 16);
            label2.TabIndex = 5;
            label2.Text = "Матрица 3x4";
            // 
            // dataGridView3x4
            // 
            dataGridView3x4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3x4.Location = new Point(13, 37);
            dataGridView3x4.Margin = new Padding(4, 4, 4, 4);
            dataGridView3x4.Name = "dataGridView3x4";
            dataGridView3x4.Size = new Size(467, 123);
            dataGridView3x4.TabIndex = 6;
            // 
            // btnFill3x4
            // 
            btnFill3x4.Location = new Point(13, 167);
            btnFill3x4.Margin = new Padding(4, 4, 4, 4);
            btnFill3x4.Name = "btnFill3x4";
            btnFill3x4.Size = new Size(175, 37);
            btnFill3x4.TabIndex = 7;
            btnFill3x4.Text = "Заполнить 3x4";
            btnFill3x4.UseVisualStyleBackColor = true;
            btnFill3x4.Click += btnFill3x4_Click;
            // 
            // btnFindMinRows
            // 
            btnFindMinRows.Location = new Point(195, 167);
            btnFindMinRows.Margin = new Padding(4, 4, 4, 4);
            btnFindMinRows.Name = "btnFindMinRows";
            btnFindMinRows.Size = new Size(233, 37);
            btnFindMinRows.TabIndex = 8;
            btnFindMinRows.Text = "Найти минимумы в строках";
            btnFindMinRows.UseVisualStyleBackColor = true;
            btnFindMinRows.Click += btnFindMinRows_Click;
            // 
            // txtResult3x4
            // 
            txtResult3x4.Location = new Point(435, 167);
            txtResult3x4.Margin = new Padding(4, 4, 4, 4);
            txtResult3x4.Multiline = true;
            txtResult3x4.Name = "txtResult3x4";
            txtResult3x4.Size = new Size(277, 73);
            txtResult3x4.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 257);
            Controls.Add(txtResult3x4);
            Controls.Add(btnFindMinRows);
            Controls.Add(btnFill3x4);
            Controls.Add(dataGridView3x4);
            Controls.Add(label2);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "Операции с матрицами";
            ((System.ComponentModel.ISupportInitialize)dataGridView3x4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3x4;
        private System.Windows.Forms.Button btnFill3x4;
        private System.Windows.Forms.Button btnFindMinRows;
        private System.Windows.Forms.TextBox txtResult3x4;
    }
}