using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Practice23.Task3
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            студентыToolStripMenuItem = new ToolStripMenuItem();
            добавитьСтудентаToolStripMenuItem = new ToolStripMenuItem();
            редактироватьСтудентаToolStripMenuItem = new ToolStripMenuItem();
            удалитьСтудентаToolStripMenuItem = new ToolStripMenuItem();
            сортировкаToolStripMenuItem = new ToolStripMenuItem();
            сортировкаПоГруппеToolStripMenuItem = new ToolStripMenuItem();
            сортировкаПоФИОToolStripMenuItem = new ToolStripMenuItem();
            сортировкаПоСреднемуБаллуToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            поискПоГруппеToolStripMenuItem = new ToolStripMenuItem();
            поискПоФИОToolStripMenuItem = new ToolStripMenuItem();
            отличникиToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] {
            файлToolStripMenuItem,
            студентыToolStripMenuItem,
            сортировкаToolStripMenuItem,
            поискToolStripMenuItem,
            справкаToolStripMenuItem});
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(884, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            открытьToolStripMenuItem,
            сохранитьToolStripMenuItem,
            сохранитьКакToolStripMenuItem,
            toolStripSeparator1,
            выходToolStripMenuItem});
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(184, 22);
            открытьToolStripMenuItem.Text = "Открыть...";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(184, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(184, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(181, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(184, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // студентыToolStripMenuItem
            // 
            студентыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            добавитьСтудентаToolStripMenuItem,
            редактироватьСтудентаToolStripMenuItem,
            удалитьСтудентаToolStripMenuItem});
            студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            студентыToolStripMenuItem.Size = new Size(75, 20);
            студентыToolStripMenuItem.Text = "Студенты";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            добавитьСтудентаToolStripMenuItem.Image = (Image)resources.GetObject("добавитьСтудентаToolStripMenuItem.Image");
            добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            добавитьСтудентаToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            добавитьСтудентаToolStripMenuItem.Size = new Size(227, 22);
            добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            добавитьСтудентаToolStripMenuItem.Click += добавитьСтудентаToolStripMenuItem_Click;
            // 
            // редактироватьСтудентаToolStripMenuItem
            // 
            редактироватьСтудентаToolStripMenuItem.Image = (Image)resources.GetObject("редактироватьСтудентаToolStripMenuItem.Image");
            редактироватьСтудентаToolStripMenuItem.Name = "редактироватьСтудентаToolStripMenuItem";
            редактироватьСтудентаToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            редактироватьСтудентаToolStripMenuItem.Size = new Size(227, 22);
            редактироватьСтудентаToolStripMenuItem.Text = "Редактировать студента";
            редактироватьСтудентаToolStripMenuItem.Click += редактироватьСтудентаToolStripMenuItem_Click;
            // 
            // удалитьСтудентаToolStripMenuItem
            // 
            удалитьСтудентаToolStripMenuItem.Image = (Image)resources.GetObject("удалитьСтудентаToolStripMenuItem.Image");
            удалитьСтудентаToolStripMenuItem.Name = "удалитьСтудентаToolStripMenuItem";
            удалитьСтудентаToolStripMenuItem.ShortcutKeys = Keys.Delete;
            удалитьСтудентаToolStripMenuItem.Size = new Size(227, 22);
            удалитьСтудентаToolStripMenuItem.Text = "Удалить студента";
            удалитьСтудентаToolStripMenuItem.Click += удалитьСтудентаToolStripMenuItem_Click;
            // 
            // сортировкаToolStripMenuItem
            // 
            сортировкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            сортировкаПоГруппеToolStripMenuItem,
            сортировкаПоФИОToolStripMenuItem,
            сортировкаПоСреднемуБаллуToolStripMenuItem});
            сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            сортировкаToolStripMenuItem.Size = new Size(85, 20);
            сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // сортировкаПоГруппеToolStripMenuItem
            // 
            сортировкаПоГруппеToolStripMenuItem.Name = "сортировкаПоГруппеToolStripMenuItem";
            сортировкаПоГруппеToolStripMenuItem.Size = new Size(202, 22);
            сортировкаПоГруппеToolStripMenuItem.Text = "По группе";
            сортировкаПоГруппеToolStripMenuItem.Click += сортировкаПоГруппеToolStripMenuItem_Click;
            // 
            // сортировкаПоФИОToolStripMenuItem
            // 
            сортировкаПоФИОToolStripMenuItem.Name = "сортировкаПоФИОToolStripMenuItem";
            сортировкаПоФИОToolStripMenuItem.Size = new Size(202, 22);
            сортировкаПоФИОToolStripMenuItem.Text = "По ФИО";
            сортировкаПоФИОToolStripMenuItem.Click += сортировкаПоФИОToolStripMenuItem_Click;
            // 
            // сортировкаПоСреднемуБаллуToolStripMenuItem
            // 
            сортировкаПоСреднемуБаллуToolStripMenuItem.Name = "сортировкаПоСреднемуБаллуToolStripMenuItem";
            сортировкаПоСреднемуБаллуToolStripMenuItem.Size = new Size(202, 22);
            сортировкаПоСреднемуБаллуToolStripMenuItem.Text = "По среднему баллу";
            сортировкаПоСреднемуБаллуToolStripMenuItem.Click += сортировкаПоСреднемуБаллуToolStripMenuItem_Click;
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            поискПоГруппеToolStripMenuItem,
            поискПоФИОToolStripMenuItem,
            отличникиToolStripMenuItem});
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(54, 20);
            поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискПоГруппеToolStripMenuItem
            // 
            поискПоГруппеToolStripMenuItem.Name = "поискПоГруппеToolStripMenuItem";
            поискПоГруппеToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            поискПоГруппеToolStripMenuItem.Size = new Size(217, 22);
            поискПоГруппеToolStripMenuItem.Text = "По группе";
            поискПоГруппеToolStripMenuItem.Click += поискПоГруппеToolStripMenuItem_Click;
            // 
            // поискПоФИОToolStripMenuItem
            // 
            поискПоФИОToolStripMenuItem.Name = "поискПоФИОToolStripMenuItem";
            поискПоФИОToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            поискПоФИОToolStripMenuItem.Size = new Size(217, 22);
            поискПоФИОToolStripMenuItem.Text = "По ФИО";
            поискПоФИОToolStripMenuItem.Click += поискПоФИОToolStripMenuItem_Click;
            // 
            // отличникиToolStripMenuItem
            // 
            отличникиToolStripMenuItem.Name = "отличникиToolStripMenuItem";
            отличникиToolStripMenuItem.Size = new Size(217, 22);
            отличникиToolStripMenuItem.Text = "Отличники";
            отличникиToolStripMenuItem.Click += отличникиToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            оПрограммеToolStripMenuItem});
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 24);
            dataGridView.Margin = new Padding(4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(884, 437);
            dataGridView.TabIndex = 1;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] {
            toolStripStatusLabel});
            statusStrip.Location = new Point(0, 461);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(884, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(118, 17);
            toolStripStatusLabel.Text = "Количество студентов";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 483);
            Controls.Add(dataGridView);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            MinimumSize = new Size(900, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учет успеваемости студентов";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem студентыToolStripMenuItem;
        private ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private ToolStripMenuItem редактироватьСтудентаToolStripMenuItem;
        private ToolStripMenuItem удалитьСтудентаToolStripMenuItem;
        private ToolStripMenuItem сортировкаToolStripMenuItem;
        private ToolStripMenuItem сортировкаПоГруппеToolStripMenuItem;
        private ToolStripMenuItem сортировкаПоФИОToolStripMenuItem;
        private ToolStripMenuItem сортировкаПоСреднемуБаллуToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripMenuItem поискПоГруппеToolStripMenuItem;
        private ToolStripMenuItem поискПоФИОToolStripMenuItem;
        private ToolStripMenuItem отличникиToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private DataGridView dataGridView;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}