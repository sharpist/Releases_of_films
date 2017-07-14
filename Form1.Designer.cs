namespace Releases_of_films
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.info = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxDel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIn
            // 
            this.buttonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIn.Location = new System.Drawing.Point(373, 258);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(100, 30);
            this.buttonIn.TabIndex = 0;
            this.buttonIn.Text = "Сохранить";
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOut.Location = new System.Drawing.Point(373, 333);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(100, 30);
            this.buttonOut.TabIndex = 1;
            this.buttonOut.Text = "Отобразить";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOut.Location = new System.Drawing.Point(12, 149);
            this.textBoxOut.MaximumSize = new System.Drawing.Size(350, 300);
            this.textBoxOut.MinimumSize = new System.Drawing.Size(350, 300);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(350, 300);
            this.textBoxOut.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Релиз";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(238, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фильм";
            // 
            // textBoxIn
            // 
            this.textBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIn.Location = new System.Drawing.Point(12, 77);
            this.textBoxIn.MaximumSize = new System.Drawing.Size(350, 35);
            this.textBoxIn.MinimumSize = new System.Drawing.Size(350, 35);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(350, 35);
            this.textBoxIn.TabIndex = 5;
            this.textBoxIn.Text = "\r\n";
            this.textBoxIn.MouseEnter += new System.EventHandler(this.textBoxIn_MouseEnter);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.help});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(484, 24);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(48, 20);
            this.file.Text = "Файл";
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(108, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(68, 20);
            this.help.Text = "Помощь";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(148, 22);
            this.info.Text = "Информация";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(138, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ввод данных";
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(428, 425);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(45, 24);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxDel
            // 
            this.textBoxDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDel.Location = new System.Drawing.Point(373, 425);
            this.textBoxDel.MaximumSize = new System.Drawing.Size(45, 24);
            this.textBoxDel.MinimumSize = new System.Drawing.Size(45, 24);
            this.textBoxDel.Name = "textBoxDel";
            this.textBoxDel.Size = new System.Drawing.Size(45, 24);
            this.textBoxDel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(368, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Удалить фильм";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDel);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonIn);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form";
            this.Text = "Релизы фильмов";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxDel;
        private System.Windows.Forms.Label label4;
    }
}

