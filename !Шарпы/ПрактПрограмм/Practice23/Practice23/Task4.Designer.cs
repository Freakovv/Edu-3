namespace Practice23
{
    partial class Task4
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPointCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericElasticity = new System.Windows.Forms.NumericUpDown();
            this.btnPlot = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPointCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericElasticity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(760, 508);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Points:";
            // 
            // numericPointCount
            // 
            this.numericPointCount.Location = new System.Drawing.Point(122, 13);
            this.numericPointCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericPointCount.Name = "numericPointCount";
            this.numericPointCount.Size = new System.Drawing.Size(120, 20);
            this.numericPointCount.TabIndex = 2;
            this.numericPointCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elasticity Factor:";
            // 
            // numericElasticity
            // 
            this.numericElasticity.DecimalPlaces = 1;
            this.numericElasticity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericElasticity.Location = new System.Drawing.Point(343, 13);
            this.numericElasticity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericElasticity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericElasticity.Name = "numericElasticity";
            this.numericElasticity.Size = new System.Drawing.Size(120, 20);
            this.numericElasticity.TabIndex = 4;
            this.numericElasticity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(469, 10);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 5;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(550, 10);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 6;
            this.btnFont.Text = "Font...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.numericElasticity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericPointCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Task4";
            this.Text = "Function Plotter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPointCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericElasticity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPointCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericElasticity;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}