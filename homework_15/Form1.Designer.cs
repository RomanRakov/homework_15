namespace homework_15
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
            this.ViewCard = new System.Windows.Forms.Button();
            this.FIO = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.arrivaldate = new System.Windows.Forms.Label();
            this.departuredate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GuestTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.all = new System.Windows.Forms.RadioButton();
            this.discharged = new System.Windows.Forms.RadioButton();
            this.free = new System.Windows.Forms.RadioButton();
            this.busy = new System.Windows.Forms.RadioButton();
            this.registered = new System.Windows.Forms.RadioButton();
            this.Time = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Find)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewCard
            // 
            this.ViewCard.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ViewCard.ForeColor = System.Drawing.Color.Black;
            this.ViewCard.Location = new System.Drawing.Point(779, 373);
            this.ViewCard.Name = "ViewCard";
            this.ViewCard.Size = new System.Drawing.Size(145, 35);
            this.ViewCard.TabIndex = 21;
            this.ViewCard.Text = "Просмотр карточки";
            this.ViewCard.UseVisualStyleBackColor = false;
            this.ViewCard.Click += new System.EventHandler(this.ViewCard_Click);
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIO.Location = new System.Drawing.Point(15, 210);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(49, 22);
            this.FIO.TabIndex = 20;
            this.FIO.Text = "ФИО";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBar.Location = new System.Drawing.Point(7, 13);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(434, 26);
            this.SearchBar.TabIndex = 22;
            this.SearchBar.Click += new System.EventHandler(this.SearchBar_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(15, 127);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(96, 26);
            this.Number.TabIndex = 23;
            this.Number.Text = "Номер №";
            // 
            // Find
            // 
            this.Find.BackgroundImage = global::homework_15.Properties.Resources.search_4883;
            this.Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Find.Location = new System.Drawing.Point(398, 13);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(43, 26);
            this.Find.TabIndex = 25;
            this.Find.TabStop = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::homework_15.Properties.Resources.Hamburger_icon_svg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 37);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::homework_15.Properties.Resources._3239945;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(134, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 22);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(672, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 26;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(15, 173);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(64, 22);
            this.Status.TabIndex = 27;
            this.Status.Text = "Статус";
            // 
            // arrivaldate
            // 
            this.arrivaldate.AutoSize = true;
            this.arrivaldate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrivaldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrivaldate.Location = new System.Drawing.Point(15, 243);
            this.arrivaldate.Name = "arrivaldate";
            this.arrivaldate.Size = new System.Drawing.Size(112, 22);
            this.arrivaldate.TabIndex = 28;
            this.arrivaldate.Text = "Дата заезда:";
            // 
            // departuredate
            // 
            this.departuredate.AutoSize = true;
            this.departuredate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departuredate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departuredate.Location = new System.Drawing.Point(15, 277);
            this.departuredate.Name = "departuredate";
            this.departuredate.Size = new System.Drawing.Size(115, 22);
            this.departuredate.TabIndex = 30;
            this.departuredate.Text = "Дата выезда:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 26);
            this.label7.TabIndex = 32;
            this.label7.Text = "Статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Список гостей";
            // 
            // GuestTable
            // 
            this.GuestTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GuestTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GuestTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GuestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestTable.Location = new System.Drawing.Point(-1, 89);
            this.GuestTable.Name = "GuestTable";
            this.GuestTable.Size = new System.Drawing.Size(446, 352);
            this.GuestTable.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.all);
            this.panel1.Controls.Add(this.discharged);
            this.panel1.Controls.Add(this.free);
            this.panel1.Controls.Add(this.busy);
            this.panel1.Controls.Add(this.registered);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 450);
            this.panel1.TabIndex = 33;
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Location = new System.Drawing.Point(20, 173);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(44, 17);
            this.all.TabIndex = 37;
            this.all.TabStop = true;
            this.all.Text = "Все";
            this.all.UseVisualStyleBackColor = true;
            this.all.CheckedChanged += new System.EventHandler(this.all_CheckedChanged_1);
            // 
            // discharged
            // 
            this.discharged.AutoSize = true;
            this.discharged.Location = new System.Drawing.Point(20, 150);
            this.discharged.Name = "discharged";
            this.discharged.Size = new System.Drawing.Size(103, 17);
            this.discharged.TabIndex = 36;
            this.discharged.TabStop = true;
            this.discharged.Text = "Выписываются";
            this.discharged.UseVisualStyleBackColor = true;
            this.discharged.CheckedChanged += new System.EventHandler(this.discharged_CheckedChanged_1);
            // 
            // free
            // 
            this.free.AutoSize = true;
            this.free.Location = new System.Drawing.Point(20, 127);
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(74, 17);
            this.free.TabIndex = 35;
            this.free.TabStop = true;
            this.free.Text = "Свободно";
            this.free.UseVisualStyleBackColor = true;
            this.free.CheckedChanged += new System.EventHandler(this.free_CheckedChanged_1);
            // 
            // busy
            // 
            this.busy.AutoSize = true;
            this.busy.Location = new System.Drawing.Point(20, 104);
            this.busy.Name = "busy";
            this.busy.Size = new System.Drawing.Size(61, 17);
            this.busy.TabIndex = 34;
            this.busy.TabStop = true;
            this.busy.Text = "Занято";
            this.busy.UseVisualStyleBackColor = true;
            this.busy.CheckedChanged += new System.EventHandler(this.busy_CheckedChanged_1);
            // 
            // registered
            // 
            this.registered.AutoSize = true;
            this.registered.Location = new System.Drawing.Point(20, 81);
            this.registered.Name = "registered";
            this.registered.Size = new System.Drawing.Size(116, 17);
            this.registered.TabIndex = 33;
            this.registered.TabStop = true;
            this.registered.Text = "Зарезервировано";
            this.registered.UseVisualStyleBackColor = true;
            this.registered.CheckedChanged += new System.EventHandler(this.registered_CheckedChanged_1);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(63, 12);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(73, 22);
            this.Time.TabIndex = 32;
            this.Time.Text = "00:00;00";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(120, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Number);
            this.panel2.Controls.Add(this.Status);
            this.panel2.Controls.Add(this.departuredate);
            this.panel2.Controls.Add(this.FIO);
            this.panel2.Controls.Add(this.arrivaldate);
            this.panel2.Location = new System.Drawing.Point(641, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 449);
            this.panel2.TabIndex = 34;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(15, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 90);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.indicator);
            this.panel3.Controls.Add(this.GuestTable);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Find);
            this.panel3.Controls.Add(this.SearchBar);
            this.panel3.Location = new System.Drawing.Point(189, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 446);
            this.panel3.TabIndex = 35;
            // 
            // indicator
            // 
            this.indicator.AutoSize = true;
            this.indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indicator.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.indicator.Location = new System.Drawing.Point(8, 16);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(69, 20);
            this.indicator.TabIndex = 32;
            this.indicator.Text = "Найти...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ViewCard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Find)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewCard;
        private System.Windows.Forms.Label FIO;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.PictureBox Find;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label arrivaldate;
        private System.Windows.Forms.Label departuredate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GuestTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label indicator;
        private System.Windows.Forms.RadioButton all;
        private System.Windows.Forms.RadioButton discharged;
        private System.Windows.Forms.RadioButton free;
        private System.Windows.Forms.RadioButton busy;
        private System.Windows.Forms.RadioButton registered;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

