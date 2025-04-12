using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace Practice23.Task3
{
    partial class SearchResultsForm
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
            dataGridView = new DataGridView();
            lblResultsCount = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(14, 14);
            dataGridView.Margin = new Padding(4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(554, 300);
            dataGridView.TabIndex = 0;
            // 
            // lblResultsCount
            // 
            lblResultsCount.AutoSize = true;
            lblResultsCount.Location = new Point(14, 322);
            lblResultsCount.Margin = new Padding(4, 0, 4, 0);
            lblResultsCount.Name = "lblResultsCount";
            lblResultsCount.Size = new Size(63, 16);
            lblResultsCount.TabIndex = 1;
            lblResultsCount.Text = "Найдено:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(454, 317);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(114, 37);
            btnClose.TabIndex = 2;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // SearchResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 367);
            Controls.Add(btnClose);
            Controls.Add(lblResultsCount);
            Controls.Add(dataGridView);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchResultsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Результаты поиска";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label lblResultsCount;
        private Button btnClose;
    }
}