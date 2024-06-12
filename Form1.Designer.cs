namespace Korrect
{
    partial class Korrect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Korrect));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.File = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CoordSearch = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CoordSearchRes = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.SystemColors.Control;
            this.File.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.File.FlatAppearance.BorderSize = 0;
            this.File.ForeColor = System.Drawing.SystemColors.InfoText;
            this.File.Location = new System.Drawing.Point(1, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(75, 23);
            this.File.TabIndex = 0;
            this.File.Text = "Файл";
            this.File.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(76, 0);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(130, 23);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(206, 0);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(91, 23);
            this.Update.TabIndex = 2;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.Options.Location = new System.Drawing.Point(295, 0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(74, 23);
            this.Options.TabIndex = 3;
            this.Options.Text = "Опции";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Задайте х(столбец 1)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Задайте у(строка 1)*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CoordSearch
            // 
            this.CoordSearch.BackColor = System.Drawing.SystemColors.Control;
            this.CoordSearch.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.CoordSearch.FlatAppearance.BorderSize = 0;
            this.CoordSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CoordSearch.Location = new System.Drawing.Point(527, 31);
            this.CoordSearch.Name = "CoordSearch";
            this.CoordSearch.Size = new System.Drawing.Size(198, 23);
            this.CoordSearch.TabIndex = 8;
            this.CoordSearch.Text = "Найти точку на графике";
            this.CoordSearch.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1009, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // CoordSearchRes
            // 
            this.CoordSearchRes.AutoSize = true;
            this.CoordSearchRes.Location = new System.Drawing.Point(731, 36);
            this.CoordSearchRes.Name = "CoordSearchRes";
            this.CoordSearchRes.Size = new System.Drawing.Size(268, 16);
            this.CoordSearchRes.TabIndex = 9;
            this.CoordSearchRes.Text = "По заданным координатам точка равна";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Korrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 553);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CoordSearchRes);
            this.Controls.Add(this.CoordSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.File);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Korrect";
            this.Text = "Работа с исходной информацией";
            this.Load += new System.EventHandler(this.Korrect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CoordSearch;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label CoordSearchRes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

