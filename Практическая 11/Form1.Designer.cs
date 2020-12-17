namespace Практическая_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.add1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clear1 = new System.Windows.Forms.Button();
            this.clear2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ответВСписок1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ответВСписок2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСписок1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСписок2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 355);
            this.listBox1.TabIndex = 0;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(428, 52);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(182, 355);
            this.lb2.TabIndex = 1;
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(198, 94);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(219, 23);
            this.add1.TabIndex = 2;
            this.add1.Text = "Ответ";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Строка 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Результат поиска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат поиска";
            // 
            // clear1
            // 
            this.clear1.Location = new System.Drawing.Point(198, 134);
            this.clear1.Name = "clear1";
            this.clear1.Size = new System.Drawing.Size(219, 23);
            this.clear1.TabIndex = 7;
            this.clear1.Text = "Очистить";
            this.clear1.UseVisualStyleBackColor = true;
            this.clear1.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear2
            // 
            this.clear2.Location = new System.Drawing.Point(616, 134);
            this.clear2.Name = "clear2";
            this.clear2.Size = new System.Drawing.Size(219, 23);
            this.clear2.TabIndex = 11;
            this.clear2.Text = "Очистить";
            this.clear2.UseVisualStyleBackColor = true;
            this.clear2.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Строка 2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(616, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 9;
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(616, 94);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(219, 23);
            this.add2.TabIndex = 8;
            this.add2.Text = "Ответ";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.button4_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(616, 352);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(219, 23);
            this.info.TabIndex = 12;
            this.info.Text = "О программе";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.button5_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(616, 381);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(219, 23);
            this.quit.TabIndex = 13;
            this.quit.Text = "Выход";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ответВСписок1ToolStripMenuItem,
            this.ответВСписок2ToolStripMenuItem,
            this.очиститьСписок1ToolStripMenuItem,
            this.очиститьСписок2ToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ответВСписок1ToolStripMenuItem
            // 
            this.ответВСписок1ToolStripMenuItem.Name = "ответВСписок1ToolStripMenuItem";
            this.ответВСписок1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ответВСписок1ToolStripMenuItem.Text = "Ответ в список 1";
            this.ответВСписок1ToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // ответВСписок2ToolStripMenuItem
            // 
            this.ответВСписок2ToolStripMenuItem.Name = "ответВСписок2ToolStripMenuItem";
            this.ответВСписок2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ответВСписок2ToolStripMenuItem.Text = "Ответ в список 2";
            this.ответВСписок2ToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // очиститьСписок1ToolStripMenuItem
            // 
            this.очиститьСписок1ToolStripMenuItem.Name = "очиститьСписок1ToolStripMenuItem";
            this.очиститьСписок1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьСписок1ToolStripMenuItem.Text = "Очистить список 1";
            this.очиститьСписок1ToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // очиститьСписок2ToolStripMenuItem
            // 
            this.очиститьСписок2ToolStripMenuItem.Name = "очиститьСписок2ToolStripMenuItem";
            this.очиститьСписок2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьСписок2ToolStripMenuItem.Text = "Очистить список 2";
            this.очиститьСписок2ToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.button5_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 416);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.info);
            this.Controls.Add(this.clear2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.clear1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Практическая работа 11";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear1;
        private System.Windows.Forms.Button clear2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ответВСписок1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ответВСписок2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьСписок1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьСписок2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

