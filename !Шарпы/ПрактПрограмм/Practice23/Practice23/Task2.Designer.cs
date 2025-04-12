namespace Practice23
{
    partial class Task2
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
            comboBoxLicensePlates = new ComboBox();
            buttonDelete = new Button();
            labelModel = new Label();
            textBoxModel = new TextBox();
            labelColor = new Label();
            labelOwner = new Label();
            textBoxOwner = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelLicensePlate = new Label();
            textBoxLicensePlate = new TextBox();
            colorComboBox = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxLicensePlates
            // 
            comboBoxLicensePlates.FormattingEnabled = true;
            comboBoxLicensePlates.Location = new Point(23, 25);
            comboBoxLicensePlates.Margin = new Padding(4, 4, 4, 4);
            comboBoxLicensePlates.Name = "comboBoxLicensePlates";
            comboBoxLicensePlates.Size = new Size(233, 24);
            comboBoxLicensePlates.TabIndex = 0;
            comboBoxLicensePlates.SelectedIndexChanged += comboBoxLicensePlates_SelectedIndexChanged;
            comboBoxLicensePlates.KeyPress += comboBoxLicensePlates_KeyPress;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(23, 74);
            buttonDelete.Margin = new Padding(4, 4, 4, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(233, 37);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "УДАЛИТЬ";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(292, 62);
            labelModel.Margin = new Padding(4, 0, 4, 0);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(50, 16);
            labelModel.TabIndex = 2;
            labelModel.Text = "Модель";
            labelModel.Visible = false;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(292, 86);
            textBoxModel.Margin = new Padding(4, 4, 4, 4);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(233, 23);
            textBoxModel.TabIndex = 2;
            textBoxModel.Visible = false;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(292, 123);
            labelColor.Margin = new Padding(4, 0, 4, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(33, 16);
            labelColor.TabIndex = 4;
            labelColor.Text = "Цвет";
            labelColor.Visible = false;
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.Location = new Point(292, 185);
            labelOwner.Margin = new Padding(4, 0, 4, 0);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(93, 16);
            labelOwner.TabIndex = 6;
            labelOwner.Text = "ФИО владельца";
            labelOwner.Visible = false;
            // 
            // textBoxOwner
            // 
            textBoxOwner.Location = new Point(292, 209);
            textBoxOwner.Margin = new Padding(4, 4, 4, 4);
            textBoxOwner.Name = "textBoxOwner";
            textBoxOwner.Size = new Size(233, 23);
            textBoxOwner.TabIndex = 4;
            textBoxOwner.Visible = false;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(292, 258);
            buttonSave.Margin = new Padding(4, 4, 4, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(111, 37);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(414, 258);
            buttonCancel.Margin = new Padding(4, 4, 4, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(111, 37);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelLicensePlate
            // 
            labelLicensePlate.AutoSize = true;
            labelLicensePlate.Location = new Point(292, 14);
            labelLicensePlate.Margin = new Padding(4, 0, 4, 0);
            labelLicensePlate.Name = "labelLicensePlate";
            labelLicensePlate.Size = new Size(170, 16);
            labelLicensePlate.TabIndex = 10;
            labelLicensePlate.Text = "Гос. регистрационный номер";
            labelLicensePlate.Visible = false;
            // 
            // textBoxLicensePlate
            // 
            textBoxLicensePlate.Location = new Point(292, 38);
            textBoxLicensePlate.Margin = new Padding(4, 4, 4, 4);
            textBoxLicensePlate.Name = "textBoxLicensePlate";
            textBoxLicensePlate.ReadOnly = true;
            textBoxLicensePlate.Size = new Size(233, 23);
            textBoxLicensePlate.TabIndex = 1;
            textBoxLicensePlate.Visible = false;
            // 
            // colorComboBox
            // 
            colorComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            colorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Location = new Point(292, 148);
            colorComboBox.Margin = new Padding(4, 4, 4, 4);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new Size(233, 24);
            colorComboBox.TabIndex = 3;
            colorComboBox.Visible = false;
            colorComboBox.DrawItem += colorComboBox_DrawItem;
            colorComboBox.MeasureItem += colorComboBox_MeasureItem;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 321);
            Controls.Add(textBoxLicensePlate);
            Controls.Add(labelLicensePlate);
            Controls.Add(colorComboBox);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxOwner);
            Controls.Add(labelOwner);
            Controls.Add(labelColor);
            Controls.Add(textBoxModel);
            Controls.Add(labelModel);
            Controls.Add(buttonDelete);
            Controls.Add(comboBoxLicensePlates);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "Task2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реестр автомобилей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLicensePlates;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLicensePlate;
        private System.Windows.Forms.TextBox textBoxLicensePlate;
        private System.Windows.Forms.ComboBox colorComboBox;
    }
}